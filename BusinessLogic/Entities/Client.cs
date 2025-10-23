using System.Data.Common;

namespace dotnet_client_manager.Application.Entities;

public class Client : EntityBase
{
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

}
