using dotnet_client_manager.Application.Entities;

namespace dotnet_client_manager.Infrastructure.DataAccess;

public interface IGenericRepository<T> where T : EntityBase
{
    Task<int> InsertAsync(T entity);

    Task<bool> UpdateAsync(T entity);

    Task<bool> DeleteAsync(int id);

    Task<IEnumerable<T>> GetAllAsync();
}