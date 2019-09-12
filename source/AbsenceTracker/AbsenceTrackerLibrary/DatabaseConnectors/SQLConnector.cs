using AbsenceTrackerLibrary.Interfaces;
using AbsenceTrackerLibrary.Models;
using System.Data;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    class SQLConnector : IDatabaseConnector
    {
        public void SaveAbsence(AbsenceModel absenceModel)
        {
            //TODO implement SaveAbsence for SQLConnector
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.GetConnectionString("SQLConnectionString")))
            {
                throw new System.NotImplementedException();
            }
        }

        public void SavePerson(PersonModel personModel)
        {
            //TODO implement SavePersonalData for SQLConnector
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.GetConnectionString("SQLConnectionString")))
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
