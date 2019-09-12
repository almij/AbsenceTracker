using AbsenceTrackerLibrary.DatabaseConnectors;
using AbsenceTrackerLibrary.Interfaces;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace AbsenceTrackerLibrary
{
    public enum Database
    {
        sql,
        mongo
    }

    public static class Config
    {
        public static IDatabaseConnector DatabaseConnector { get; private set; }

        public static void Initialise(Database database, string defaultUserId)
        {
            switch (database)
            {
                case Database.sql:
                    DatabaseConnector = new SQLConnector();
                    break;
                case Database.mongo:
                    throw new ArgumentException($"Invalid argument value: '{database}' connection is not implemented", "database");
                default:
                    throw new ArgumentException("Invalid argument value", "database");
            }
        }
    }
}
