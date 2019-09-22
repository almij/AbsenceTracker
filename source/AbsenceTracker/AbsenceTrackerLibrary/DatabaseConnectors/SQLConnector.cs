﻿using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    class SqlConnector : IDatabaseConnector
    {
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
            public Byte[] password_hash;
            public string first_name;
            public string last_name;
            public string patronymic;
            public string middle_name;
            public string email;
            public string full_name_for_documents;
            public DateTime started_at;
            public int department_id;
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
            //TODO test implement GetDefaultUser in SQLConnector to replace a stub
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
                return absencesRaw.Select(
                    _ => new AbsenceModel
                    {
                        Id = _.absence_id.ToString(),
                        AbsenceType = AbsenceTracker.AbsenceTypes.SingleOrDefault(
                            __ => __.Id == _.absence_type_id.ToString()),
                        EffectiveFrom = _.effective_from,
                        ExpiresOn = _.expires_on,
                        DaysWorkedOnHolidays = _.days_worked_on_holidays
                    }).ToList();
            }
        }

        public void SaveAbsence(AbsenceModel absenceModel)
        {

            //TODO implement SaveAbsence for SQLConnector
            using (IDbConnection connection = SqlConnectionFactory())
            {
                if (absenceModel.Id is null)
                {
                    absenceModel.Id = AbsenceTracker.CurrentUser.Absences.Count.ToString();
                }
            }
        }

        public void SavePerson(PersonModel personModel)
        {
            //TODO implement SavePersonalData for SQLConnector
            using (IDbConnection connection = SqlConnectionFactory())
            {
                personModel.Id = 0.ToString();
                return;
            }
        }

        private System.Data.SqlClient.SqlConnection SqlConnectionFactory()
        {
            return new System.Data.SqlClient.SqlConnection(AbsenceTracker.GetConnectionString("SQLConnectionString"));
        }
    }
}
