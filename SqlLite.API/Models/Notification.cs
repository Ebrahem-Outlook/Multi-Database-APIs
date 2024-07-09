namespace SqlLite.API.Models;

public sealed class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Message { get; set; } = default!;         
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
}
