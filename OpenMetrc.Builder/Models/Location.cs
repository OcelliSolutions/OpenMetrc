using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class Location
{
    public int Id { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    public int LocationTypeId { get; set; }
    [MaxLength(100)] public string? LocationTypeName { get; set; }
    public bool? ForPlantBatches { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForHarvests { get; set; }
    public bool? ForPackages { get; set; }
}
