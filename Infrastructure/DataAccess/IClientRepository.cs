using ClientManager.Domain.Entities;

namespace ClientManager.Infrastructure.DataAccess;

public interface IClientRepository
{
    Task<int> InsertAsync(Client client);

    Task<bool> UpdateAsync(Client client);

    Task<bool> DeleteAsync(int id);

    Task<IEnumerable<Client>> GetAllAsync();
    Task<IEnumerable<int>> GetIdAsync();
}
