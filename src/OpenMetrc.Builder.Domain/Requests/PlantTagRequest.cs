namespace OpenMetrc.Builder.Domain.Requests;

public class PlantTagRequest
{
    public long? Id { get; set; }
    public string? Group { get; set; }
    public long? TagId { get; set; }
    public string? NewTag { get; set; }
    public DateOnly? ReplaceDate { get; set; }
}