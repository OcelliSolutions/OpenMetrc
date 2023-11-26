namespace OpenMetrc.Builder.Domain.Requests;

public class TagPlantBatchRequest
{
    public long? Id { get; set; }
    public string? Group { get; set; }
    public long? TagId { get; set; }
    public string? NewTag { get; set; }
    public string? ReplaceDate { get; set; }
}