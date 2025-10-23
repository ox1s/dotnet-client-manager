using dotnet_client_manager.Application.Entities;
using dotnet_client_manager.Infrastructure.DataAccess;

namespace dotnet_client_manager.BusinessLogic.Services
{
    internal class AddOperation : Operation
    {
        public AddOperation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override Task Execute()
        {
            string fullname = "Барабашка";
            string email = "barabashka@gmail.com";
            bool isActive = true;
            DateTime createdAt = DateTime.Now;

            var clientToCreate = new Client
            {
                FullName = fullname,
                Email = email,
                IsActive = isActive,
                CreatedAt = createdAt,
            };

            var command = _unitOfWork.Clients.InsertAsync(clientToCreate);
            return command;
        }
    }
}
