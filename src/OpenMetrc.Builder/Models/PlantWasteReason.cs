namespace OpenMetrc.Builder.Models;

public class PlantWasteReason
{
    [MaxLength(100)] public string? Name { get; set; }
    public bool RequiresNote { get; set; }
}