namespace OpenMetrc.Builder.Models;

public class Tag
{
    public long Id { get; set; }
    public string? TagTypeName { get; set; }
    public long? GroupTagTypeId { get; set; }
    public string? GroupTagTypeName { get; set; }
    public int? MaxGroupSize { get; set; }
    public long? FacilityId { get; set; }
    public string? Label { get; set; }
}
