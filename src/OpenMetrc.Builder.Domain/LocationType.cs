﻿namespace OpenMetrc.Builder.Domain;

public class LocationType
{
    [Required] public long Id { get; set; }

    public string? Name { get; set; }
    public bool? ForPlantBatches { get; set; }
    public bool? ForPlants { get; set; }
    public bool? ForHarvests { get; set; }
    public bool? ForPackages { get; set; }
}