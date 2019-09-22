using AbsenceTrackerLibrary.DatabaseConnectors;
using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AbsenceTrackerLibrary
{
    public enum Database
    {
        Sql,
        MongoDB
    }

    public static class AbsenceTracker
    {
        private static IDatabaseConnector Database { get; set; }
        public static PersonModel CurrentUser { get; private set; }

        public static void Initialise(Database database, PersonModel user = null)
        {
            switch (database)
            {
                case AbsenceTrackerLibrary.Database.Sql:
                    Database = new SqlConnector();
                    break;
                case AbsenceTrackerLibrary.Database.MongoDB:
                    throw new ArgumentException($"Invalid argument value: '{database}' connection is not implemented", "database");
                default:
                    throw new ArgumentException("Invalid argument value", "database");
            }
            CurrentUser = user ?? Database.GetDefaultUser();
        }

        public static void Save()
        {
            Database.SavePerson(CurrentUser);
        }

        public static void SaveAbsence(AbsenceModel absence)
        {
            if (absence.Id is null)
            {
                CurrentUser.Absences.Add(absence);
                CurrentUser.Absences.Sort();
            }
            Database.SaveAbsence(absence);
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
