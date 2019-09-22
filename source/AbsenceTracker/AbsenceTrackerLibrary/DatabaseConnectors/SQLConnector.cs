using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    class SqlConnector : IDatabaseConnector
    {
        public void DeleteAbsence(AbsenceModel absence)
        {
            //TODO implement DeleteAbsence in SQLConnector to replace a stub
            return;
        }

        public PersonModel GetDefaultUser()
        {
            //TODO implement GetDefaultUser in SQLConnector to replace a stub
            var user = new PersonModel
            {
                FirstName = "John",
                LastName = "Doe",
                Absences = new List<AbsenceModel>() { new AbsenceModel() { AbsenceType = null, EffectiveFrom = DateTime.Today, ExpiresOn = DateTime.Today, DaysWorkedOnHolidays = 0 } }
            };
            return user;
        }

        public void SaveAbsence(AbsenceModel absenceModel)
        {

            //TODO implement SaveAbsence for SQLConnector
            using (IDbConnection connection = SqlConnectionFactory())
            {
                return;
            }
        }

        public void SavePerson(PersonModel personModel)
        {
            //TODO implement SavePersonalData for SQLConnector
            using (IDbConnection connection = SqlConnectionFactory())
            {
                return;
            }
        }

        private System.Data.SqlClient.SqlConnection SqlConnectionFactory()
        {
            return new System.Data.SqlClient.SqlConnection(AbsenceTracker.GetConnectionString("SQLConnectionString"));
        }
    }
}
