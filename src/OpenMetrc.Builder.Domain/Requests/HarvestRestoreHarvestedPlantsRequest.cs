namespace OpenMetrc.Builder.Domain.Requests;

public class HarvestRestoreHarvestedPlantsRequest
{
    public long HarvestId { get; set; }
    public string[]? PlantTags { get; set; }
}