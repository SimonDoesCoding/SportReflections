using System.Data;
using Npgsql;
using SportReflections.Common.Interfaces;

namespace SportReflections.Common
{
    public class DbContext : IDbContext
    {
        public IDbConnection CreateConnection(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}

