using dotnet_client_manager.Application.Entities;

namespace dotnet_client_manager.Infrastructure.DataAccess;

public interface IClientRepository
{
    Task<int> InsertAsync(Client client);

    Task<bool> UpdateAsync(Client client);

    Task<bool> DeleteAsync(int id);

    Task<IEnumerable<Client>> GetAllAsync();
    Task<IEnumerable<int>> GetIdAsync();
}
