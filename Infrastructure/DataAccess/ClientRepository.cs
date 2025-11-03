using Dapper;
using dotnet_client_manager.Application.Entities;
using dotnet_client_manager.Infrastructure.Factories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace dotnet_client_manager.Infrastructure.DataAccess;

public class ClientRepository : IClientRepository
{
    private readonly SqlConnectionFactory _connectionFactory;

    public ClientRepository(SqlConnectionFactory connectionFactory) => _connectionFactory = connectionFactory;

    public async Task<bool> DeleteAsync(int id)
    {
        var query = @"delete * from Clients where Id = @Id;";
        using (IDbConnection connection = _connectionFactory.CreateConnection())
        {   
            var result = await connection.ExecuteAsync(query, new { Id = id });
            return result > 0;
        }
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        var query = @"select * from Clients;";
        using (IDbConnection connection = _connectionFactory.CreateConnection())
        {
            var result = await connection.QueryAsync<Client>(query);
            return result.ToList();
        }
    }

    public async Task<IEnumerable<int>> GetIdAsync()
    {
        var query = @"select Id from Clients;";
        using (IDbConnection connection = _connectionFactory.CreateConnection())
        {
            var result = await connection.QueryAsync<int>(query);
            return result.ToList();
        }
    }


    public async Task<int> InsertAsync(Client client)
    {
        var query = @"
                    insert into Clients(FullName, Email, IsActive, CreatedAt)
                    values (@FullName, @Email, @IsActive, @CreatedAt)
                    ";
        using (IDbConnection connection = _connectionFactory.CreateConnection())
        {
            var result = await connection.ExecuteAsync(query, client);
            return result;
        }
    }

    public async Task<bool> UpdateAsync(Client client)
    {
        var query = @"
                    update Clients SET 
                        FullName = @FullName, 
                        Email = @Email,
                        IsActive = @IsActive,
                        CreatedAt = @CreatedAt
                    where Id = @id
                    ";
        using (IDbConnection connection = _connectionFactory.CreateConnection())
        {
            var result = await connection.ExecuteAsync(query, client);
            return result > 0;
        }
    }

}
