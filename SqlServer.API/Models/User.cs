namespace SqlServer.API.Models;

public sealed class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = default!;
    public string PasswordHash { get;set; } = default!;
    public string Email { get; set; } = default!;
}
