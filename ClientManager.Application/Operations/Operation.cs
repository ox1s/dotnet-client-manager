using ClientManager.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.Operations
{
    internal abstract class Operation
    {
        public readonly IClientRepository _clientRepository;

        protected Operation(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public abstract Task Execute();
    }
}
