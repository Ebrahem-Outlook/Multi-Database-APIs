namespace MySQL.API.Models;

public class Media
{
    public int Id { get; set; }
    public string Url { get; set; }
    public string Type { get; set; }
    public int ContentId { get; set; }
    public DateTime UploadedAt { get; set; }
}
