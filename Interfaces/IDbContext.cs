using System.Data;

namespace SportReflections.Common.Interfaces
{
    public interface IDbContext
    {
        IDbConnection CreateConnection(string connectionString);
    }
}

