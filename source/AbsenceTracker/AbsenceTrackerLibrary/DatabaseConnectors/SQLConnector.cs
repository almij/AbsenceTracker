using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    //TODO replace all the raw Sql with StoredProc calls
    internal abstract class SqlConnector : IDatabaseConnector
    {
        protected abstract string ParamChar { get; }

        //TODO mapping using structs is ugly, Dapper is said to have a mechanism for non-name-to-name mapping, research
        private struct AbsenceTypeMapper
        {
            public int absence_type_id;
            public string absence_type_name;
            public int is_day_off;
            public int is_overtime;
        }

        private struct AbsenceMapper
        {
            public int absence_id;
            public int absence_type_id;
            public int person_id;
            public DateTime effective_from;
            public DateTime expires_on;
            public int days_worked_on_holidays;
        }

        private struct PersonMapper
        {
            public int person_id;
            public string username;
            public string first_name;
            public string last_name;
            public string patronymic;
            public string middle_name;
            public string email;
            public string full_name_for_documents;
            public DateTime started_at;
        }

        public void DeleteAbsence(AbsenceModel absence)
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var param = new DynamicParameters();
                param.Add($"{ParamChar}absence_id", int.Parse(absence.Id));
                connection.Execute("dbo.sp_delete_absence", param, commandType: CommandType.StoredProcedure);
            }
        }

        public List<AbsenceTypeModel> GetAbsenceTypes()
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var absenceTypeMappers = connection.Query<AbsenceTypeMapper>("select * from dbo.absence_type;");
                return absenceTypeMappers.Select(
                    _ => new AbsenceTypeModel
                    {
                        Id = _.absence_type_id.ToString(),
                        Name = _.absence_type_name,
                        IsDayOff = _.is_day_off == 0 ? false : true,
                        IsOvertime = _.is_overtime == 0 ? false : true
                    }).ToList();
            }
        }

        protected abstract string SelectStarTop1(string table);

        public PersonModel GetDefaultUser()
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var personMappers = connection.Query<PersonMapper>(SelectStarTop1("dbo.person"));
                if (personMappers.Count() == 0)
                {
                    return new PersonModel();
                }
                else
                {
                    var personMapper = personMappers.ElementAt(0);
                    return new PersonModel
                    {
                        Id = personMapper.person_id.ToString(),
                        Username = personMapper.username,
                        FirstName = personMapper.first_name,
                        LastName = personMapper.last_name,
                        Patronymic = personMapper.patronymic,
                        MiddleName = personMapper.middle_name,
                        Email = personMapper.email,
                        FullNameForDocuments = personMapper.full_name_for_documents,
                        StartedAt = personMapper.started_at,
                        Absences = GetAbsences(personMapper.person_id)
                    };
                }
            }
        }

        private List<AbsenceModel> GetAbsences(int personId)
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var absenceMappers = connection.Query<AbsenceMapper>(
                    $"select * from dbo.absence where person_id = '{ personId }'");
                var absences = absenceMappers.Select(
                    _ => new AbsenceModel
                    {
                        Id = _.absence_id.ToString(),
                        AbsenceType = AbsenceTracker.AbsenceTypes.SingleOrDefault(
                            __ => __.Id == _.absence_type_id.ToString()),
                        EffectiveFrom = _.effective_from,
                        ExpiresOn = _.expires_on,
                        DaysWorkedOnHolidays = _.days_worked_on_holidays
                    }).ToList();
                absences.Sort();
                return absences;
            }
        }

        public void SaveAbsence(AbsenceModel absence)
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var param = new DynamicParameters();
                param.Add($"{ParamChar}person_id", int.Parse(AbsenceTracker.CurrentUser.Id));
                param.Add($"{ParamChar}absence_type_id", int.Parse(absence.AbsenceType.Id));
                param.Add($"{ParamChar}effective_from", absence.EffectiveFrom);
                param.Add($"{ParamChar}expires_on", absence.ExpiresOn);
                param.Add($"{ParamChar}days_worked_on_holidays", absence.DaysWorkedOnHolidays);
                if (absence.Id is null)
                {
                    param.Add($"{ParamChar}absence_id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.sp_insert_absence", param, commandType: CommandType.StoredProcedure);
                    absence.Id = param.Get<int>($"{ParamChar}absence_id").ToString();
                }
                else
                {
                    param.Add($"{ParamChar}absence_id", int.Parse(absence.Id), dbType: DbType.Int32);
                    connection.Execute("dbo.sp_update_absence", param, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void SavePerson(PersonModel personModel)
        {
            using (IDbConnection connection = ConnectionFactory())
            {
                var param = new DynamicParameters();
                param.Add($"{ParamChar}username", personModel.Username);
                param.Add($"{ParamChar}first_name", personModel.FirstName);
                param.Add($"{ParamChar}last_name", personModel.LastName);
                param.Add($"{ParamChar}patronymic", personModel.Patronymic);
                param.Add($"{ParamChar}middle_name", personModel.MiddleName);
                param.Add($"{ParamChar}email", personModel.Email);
                param.Add($"{ParamChar}full_name_for_documents", personModel.FullNameForDocuments);
                param.Add($"{ParamChar}started_at", personModel.StartedAt);
                if(personModel.Id is null)
                {
                    param.Add($"{ParamChar}person_id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.sp_insert_person", param, commandType: CommandType.StoredProcedure);
                    personModel.Id = param.Get<int>($"{ParamChar}person_id").ToString();
                }
                else
                {
                    param.Add($"{ParamChar}person_id", int.Parse(personModel.Id), dbType: DbType.Int32);
                    connection.Execute("dbo.sp_update_person", param, commandType: CommandType.StoredProcedure);
                }
                return;
            }
        }

        protected abstract IDbConnection ConnectionFactory();

        public PersonModel GetUser(string username, byte[] password = null)
        {
            throw new NotImplementedException();
        }
    }
}
