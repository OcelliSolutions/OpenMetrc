namespace OpenMetrc.Builder.Models;

public class Location
{
    [Required] public long Id { get; set; }

    public string? Name { get; set; }
    public long LocationTypeId { get; set; }
    public string? LocationTypeName { get; set; }
    public bool? ForPlantBatches { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForHarvests { get; set; }
    public bool? ForPackages { get; set; }
}