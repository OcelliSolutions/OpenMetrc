namespace OpenMetrc.Builder.Domain;

public class PlantBatchWasteReason
{
    public string Name { get; set; } = null!;
    public bool? RequiresNote { get; set; }
    public bool? RequiresWasteWeight { get; set; }
    public bool? RequiresImmatureWasteWeight { get; set; }
    public bool? RequiresMatureWasteWeight { get; set; }
}