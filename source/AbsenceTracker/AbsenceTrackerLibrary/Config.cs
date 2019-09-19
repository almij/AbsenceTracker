using AbsenceTrackerLibrary.DatabaseConnectors;
using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using System;
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

    public static class Config
    {
        public static IDatabaseConnector Database { get; private set; }

        public static void Initialise(Database database)
        {
            switch (database)
            {
                case AbsenceTrackerLibrary.Database.Sql:
                    Database = new SQLConnector();
                    break;
                case AbsenceTrackerLibrary.Database.MongoDB:
                    throw new ArgumentException($"Invalid argument value: '{database}' connection is not implemented", "database");
                default:
                    throw new ArgumentException("Invalid argument value", "database");
            }
        }

        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
