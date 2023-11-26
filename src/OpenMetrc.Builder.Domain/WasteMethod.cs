namespace OpenMetrc.Builder.Domain;

public class WasteMethod
{
    public string Name { get; set; } = null!;
    public bool? ForPlants { get; set; }
    public bool? ForProductDestruction { get; set; }
    public DateTime? LastModified { get; set; }
}