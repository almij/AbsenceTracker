using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    internal class MSSQLServerConnector : SqlConnector
    {
        protected override string ParamChar => "@";

        protected override string SelectStarTop1(string table) => $"select top 1 * from {table}";

        protected override IDbConnection ConnectionFactory()
        {
            return new SqlConnection(AbsenceTracker.GetConnectionString("MSSQLServerConnectionString"));
        }
    }
}
