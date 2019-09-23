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
    class SqlConnector : IDatabaseConnector
    {
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
            using (IDbConnection connection = SqlConnectionFactory())
            {
                connection.Query<AbsenceTypeMapper>(
                    $"delete absence where absence_id = '{int.Parse(absence.Id)}'");
            }
        }

        public List<AbsenceTypeModel> GetAbsenceTypes()
        {
            using (IDbConnection connection = SqlConnectionFactory())
            {
                var absenceTypesRaw = connection.Query<AbsenceTypeMapper>("select * from absence_type");
                return absenceTypesRaw.Select(
                    _ => new AbsenceTypeModel
                    {
                        Id = _.absence_type_id.ToString(),
                        Name = _.absence_type_name,
                        IsDayOff = _.is_day_off == 0 ? false : true,
                        IsOvertime = _.is_overtime == 0 ? false : true
                    }).ToList();
            }
        }

        public PersonModel GetDefaultUser()
        {
            using (IDbConnection connection = SqlConnectionFactory())
            {
                var personsMapper = connection.Query<PersonMapper>("select top 1 * from person");
                if (personsMapper.Count() == 0)
                {
                    return new PersonModel();
                }
                else
                {
                    var personMapper = personsMapper.ElementAt(0);
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
            using (IDbConnection connection = SqlConnectionFactory())
            {
                var absencesRaw = connection.Query<AbsenceMapper>(
                    $"select * from absence where person_id = '{ personId }'");
                var absences = absencesRaw.Select(
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
            using (IDbConnection connection = SqlConnectionFactory())
            {
                var param = new DynamicParameters();
                param.Add("@person_id", int.Parse(AbsenceTracker.CurrentUser.Id));
                param.Add("@absence_type_id", int.Parse(absence.AbsenceType.Id));
                param.Add("@effective_from", absence.EffectiveFrom);
                param.Add("@expires_on", absence.ExpiresOn);
                param.Add("@days_worked_on_holidays", absence.DaysWorkedOnHolidays);
                if (absence.Id is null)
                {
                    param.Add("@absence_id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spInsertAbsence", param, commandType: CommandType.StoredProcedure);
                    absence.Id = param.Get<int>("@absence_id").ToString();
                }
                else
                {
                    param.Add("@absence_id", int.Parse(absence.Id), dbType: DbType.Int32);
                    connection.Execute("dbo.spUpdateAbsence", param, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void SavePerson(PersonModel personModel)
        {
            using (IDbConnection connection = SqlConnectionFactory())
            {
                var param = new DynamicParameters();
                param.Add("@username", AbsenceTracker.CurrentUser.Username);
                param.Add("@first_name", AbsenceTracker.CurrentUser.FirstName);
                param.Add("@last_name", AbsenceTracker.CurrentUser.LastName);
                param.Add("@patronymic", AbsenceTracker.CurrentUser.Patronymic);
                param.Add("@middle_name", AbsenceTracker.CurrentUser.MiddleName);
                param.Add("@email", AbsenceTracker.CurrentUser.Email);
                param.Add("@full_name_for_documents", AbsenceTracker.CurrentUser.FullNameForDocuments);
                param.Add("@started_at", AbsenceTracker.CurrentUser.StartedAt);
                if(AbsenceTracker.CurrentUser.Id is null)
                {
                    param.Add("@person_id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spInsertPerson", param, commandType: CommandType.StoredProcedure);
                    AbsenceTracker.CurrentUser.Id = param.Get<int>("@person_id").ToString();
                }
                else
                {
                    param.Add("@person_id", int.Parse(AbsenceTracker.CurrentUser.Id), dbType: DbType.Int32);
                    connection.Execute("dbo.spUpdatePerson", param, commandType: CommandType.StoredProcedure);
                }
                return;
            }
        }

        private System.Data.SqlClient.SqlConnection SqlConnectionFactory()
        {
            return new System.Data.SqlClient.SqlConnection(AbsenceTracker.GetConnectionString("SQLConnectionString"));
        }
    }
}
