namespace OpenMetrc.Builder.Models.Requests;

public class ManicurePlantRequest
{
    public ManicurePlantRequest()
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
