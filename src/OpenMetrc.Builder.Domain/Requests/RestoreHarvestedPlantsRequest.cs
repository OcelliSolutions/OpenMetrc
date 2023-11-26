namespace OpenMetrc.Builder.Domain.Requests;

public class RestoreHarvestedPlantsRequest
{
    public long HarvestId { get; set; }
    public string[] PlantTags { get; set; } = null!;
}