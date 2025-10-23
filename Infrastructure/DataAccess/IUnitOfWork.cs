namespace dotnet_client_manager.Infrastructure.DataAccess;

public interface IUnitOfWork
{
    IClientRepository Clients { get; }
}
