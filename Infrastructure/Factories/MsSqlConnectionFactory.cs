using Microsoft.Data.SqlClient;
using System.Data;

namespace ClientManager.Infrastructure.Factories
{
    internal class MsSqlConnectionFactory : SqlConnectionFactory
    {
        public MsSqlConnectionFactory() : base("MsSqlConnection") { }

    }
}
