using AbsenceTrackerLibrary.DatabaseConnectors;
using AbsenceTrackerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbsenceTrackerLibrary
{
    public enum Database
    {
        Sql
    }

    public static class Config
    {
        public static IDatabaseConnector DatabaseConnector { get; private set; }

        public static void Initialise(Database database, string defaultUserId)
        {
            switch (database)
            {
                case Database.Sql:
                    DatabaseConnector = new SQLConnector();
                    break;
                default:
                    throw new ArgumentException("Invalid argument value", "database");
            }
        }
    }
}
