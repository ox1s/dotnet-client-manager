using ClientManager.Domain.Entities;
using ClientManager.Infrastructure.DataAccess;

namespace ClientManager.Application.Operations
{
    internal class AddOperation : Operation
    {
        public AddOperation(IClientRepository clientRepository) : base(clientRepository)
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

            var command = _clientRepository.InsertAsync(clientToCreate);
            return command;
        }
    }
}
