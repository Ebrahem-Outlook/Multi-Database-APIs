namespace Oracle.API.Models;

public sealed class ContentAnalytics
{
    public int Id { get; set; }
    public int ContentId { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }
    public int Shares { get; set; }
    public DateTime CreatedAt { get; set; }
}
