using dotnet_client_manager.Application.Entities;
using dotnet_client_manager.Infrastructure.DataAccess;
using Spectre.Console;

namespace dotnet_client_manager.BusinessLogic.Services
{
    internal class DeleteOperation : Operation
    {
        public DeleteOperation(IClientRepository clientRepository) : base(clientRepository)
        {
        }

        public override async Task Execute()
        {
            var ids = await _clientRepository.GetIdAsync();
            int maxClientId = ids.Max();

            var idOfClientToDelete = AnsiConsole.Prompt(
                new TextPrompt<int>("Какого клиента вы хотите удалить? (введите номер)")
                    .Validate((n) => n switch
                    {
                        < 1 => ValidationResult.Error("Номер меньше единицы!"),
                        var x when !ids.Contains(x) => ValidationResult.Error("Такого клиента нет!"),
                        _ => ValidationResult.Success()
                    }));

            var confirmation = AnsiConsole.Prompt(
                new TextPrompt<bool>($"Удалить клиента {idOfClientToDelete}?")
                    .AddChoice(true)
                    .AddChoice(false)
                    .DefaultValue(true)
                    .WithConverter(choice => choice ? "y" : "n"));

            Console.WriteLine(confirmation ? "Подтверждено" : "Отклонено");

            var command = _clientRepository.DeleteAsync(idOfClientToDelete);
        }
    }
}
