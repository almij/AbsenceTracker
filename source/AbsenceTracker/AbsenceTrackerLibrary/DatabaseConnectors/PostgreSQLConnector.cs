using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace AbsenceTrackerLibrary.DatabaseConnectors
{
    internal class PostgreSQLConnector : SqlConnector
    {
        protected override string ParamChar => "_";

        //TODO evaluate if it's needed protected override string SelectStarTop1(string table) => $"select * from {table} fetch first 1 rows only";

        protected override IDbConnection ConnectionFactory()
        {
            return new NpgsqlConnection(AbsenceTracker.GetConnectionString("PostgreSQLHerokuConnectionString"));
        }
    }
}
