using Microsoft.Data.SqlClient;
using System.Data;

namespace dotnet_client_manager.Infrastructure.Factories
{
    internal class MsSqlConnectionFactory : SqlConnectionFactory
    {
        public MsSqlConnectionFactory() : base("MsSqlConnection") { }

    }
}
