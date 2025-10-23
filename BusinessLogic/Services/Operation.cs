using dotnet_client_manager.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_client_manager.BusinessLogic.Services
{
    internal abstract class Operation
    {
        public readonly IUnitOfWork _unitOfWork;

        protected Operation(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public abstract Task Execute();
    }
}
