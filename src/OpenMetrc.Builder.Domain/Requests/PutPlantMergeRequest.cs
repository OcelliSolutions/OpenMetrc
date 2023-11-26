namespace OpenMetrc.Builder.Domain.Requests;

public class PutPlantMergeRequest : PlantMergeRequest
{
}

public class PlantMergeRequest
{
    public string TargetPlantGroupLabel { get; set; } = null!;
    public string SourcePlantGroupLabel { get; set; } = null!;
    public DateOnly MergeDate { get; set; }
}
