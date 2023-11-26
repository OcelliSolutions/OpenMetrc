namespace OpenMetrc.Builder.Domain.Requests;

public class PlantManicurePlantsRequest
{
    public PlantManicurePlantsRequest()
    {
        Plant = string.Empty;
        UnitOfWeight = string.Empty;
        DryingLocation = string.Empty;
    }

    public string Plant { get; set; }
    public double Weight { get; set; }
    public string UnitOfWeight { get; set; }
    public string DryingLocation { get; set; }
    public string? HarvestName { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public DateTime ActualDate { get; set; }
}