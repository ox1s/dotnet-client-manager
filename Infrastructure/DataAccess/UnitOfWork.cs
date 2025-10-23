using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_client_manager.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IClientRepository clientRepository)
        {
            Clients = clientRepository;
        }
        public IClientRepository Clients { get; }
    }
}
