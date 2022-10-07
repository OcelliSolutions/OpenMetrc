namespace OpenMetrc.Builder.Models;

public class PlantWasteMethod
{
    public PlantWasteMethod()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForProductDestruction { get; set; }
    public DateTimeOffset? LastModified { get; set; }
}