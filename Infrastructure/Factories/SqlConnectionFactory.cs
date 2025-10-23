using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace dotnet_client_manager.Infrastructure.Factories
{
    public abstract class SqlConnectionFactory
    {
        protected readonly string _connectionString;
        protected SqlConnectionFactory(string dbName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("DBsettings.json");

            var configuration = builder.Build();

            _connectionString = configuration.GetConnectionString(dbName)
                ?? throw new Exception("Нет строки подлючения");
        }
        public IDbConnection CreateConnection() 
            => new SqlConnection(_connectionString);

    }
}
