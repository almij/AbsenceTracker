using AbsenceTrackerLibrary.DatabaseConnectors;
using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Security;

namespace AbsenceTrackerLibrary
{
    public enum Database
    {
        MSSQLServer,
        PostgreSQL,
        MongoDB
    }

    public static class AbsenceTracker
    {
        private static IDatabaseConnector Database { get; set; }
        public static PersonModel CurrentUser { get; private set; }
        public static List<AbsenceTypeModel> AbsenceTypes { get; internal set; }

        public static void Initialise(Database database)
        {
            switch (database)
            {
                case AbsenceTrackerLibrary.Database.MSSQLServer:
                    Database = new MSSQLServerConnector();
                    break;
                case AbsenceTrackerLibrary.Database.MongoDB:
                    throw new ArgumentException($"Invalid argument value: '{database}' connection is not implemented", "database");
                case AbsenceTrackerLibrary.Database.PostgreSQL:
                    Database = new PostgreSQLConnector();
                    break;
                default:
                    throw new ArgumentException("Invalid argument value", "database");
            }
            AbsenceTypes = Database.GetAbsenceTypes();
            CurrentUser = new PersonModel();
        }

        public static bool Login(string username, string password)
        {
            //TODO implement secure hashing solution
            byte[] passwordHash = null;
            CurrentUser = Database.GetPerson(username, passwordHash);
            return !(CurrentUser is default(PersonModel));
        }

        public static void SaveUser(PersonModel person)
        {
            Database.SavePerson(person);
            CurrentUser = person;
        }

        public static void SaveAbsence(AbsenceModel absence)
        {
            if (absence.AbsenceType.IsOvertime)
            {
                absence.DaysWorkedOnHolidays = absence.DaysTotal;
            }
            var isNew = absence.Id is null;
            Database.SaveAbsence(absence);
            if (isNew)
            {
                CurrentUser.Absences.Add(absence);
            }
            CurrentUser.Absences.Sort();
        }

        public static bool ValidateAbsenceForDublicateDatePeriod(DateTime effectiveFrom, DateTime expiresOn, string id)
        {
            var possibleDuplicate = CurrentUser.Absences.SingleOrDefault(_ =>
            {
                return _.EffectiveFrom == effectiveFrom &&
                _.ExpiresOn == expiresOn;
            });
            if (possibleDuplicate is default(AbsenceModel))
            {
                return true;
            }
            else
            {
                return id == possibleDuplicate.Id;
            }
        }

        public static void RemoveAbsence(AbsenceModel absence)
        {
            Database.DeleteAbsence(absence);
            CurrentUser.Absences.Remove(absence);
        }

        internal static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
