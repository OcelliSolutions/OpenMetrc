namespace OpenMetrc.Builder.Domain.Requests;

public class TagPlantRequest
{
    public long? Id { get; set; }
    public string? Label { get; set; }
    public long? TagId { get; set; }
    public string? NewTag { get; set; }
    public string? ReplaceDate { get; set; }
}