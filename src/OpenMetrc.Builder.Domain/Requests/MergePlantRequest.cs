namespace OpenMetrc.Builder.Domain.Requests;

public class MergePlantRequest
{
    public string TargetPlantGroupLabel { get; set; } = null!;
    public string SourcePlantGroupLabel { get; set; } = null!;
    public DateOnly MergeDate { get; set; }
}