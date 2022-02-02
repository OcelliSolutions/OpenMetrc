namespace OpenMetrc.Builder.Models;

public class LocationType
{
    public int Id { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    public bool? ForPlantBatches { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForHarvests { get; set; }
    public bool? ForPackages { get; set; }
}