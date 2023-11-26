namespace OpenMetrc.Builder.Domain;

public class PlantWasteReason
{
    public string? Name { get; set; }
    public bool? RequiresNote { get; set; }
    public bool? RequiresWasteWeight { get; set; }
    public bool? RequiresImmatureWasteWeight { get; set; }
    public bool? RequiresMatureWasteWeight { get; set; }
}