namespace OpenMetrc.Builder.Models;

public class LocationType
{
    [Required] public int Id { get; set; }

    public string? Name { get; set; }
    public bool? ForPlantBatches { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForHarvests { get; set; }
    public bool? ForPackages { get; set; }
}