namespace OpenMetrc.Builder.Domain.Requests;

public class CreatePlantPlantingsRequest
{
    public CreatePlantPlantingsRequest()
    {
        PlantLabel = string.Empty;
        PlantBatchName = string.Empty;
        PlantBatchType = string.Empty;
        StrainName = string.Empty;
    }

    public string PlantLabel { get; set; }
    public string PlantBatchName { get; set; }
    public string PlantBatchType { get; set; }
    public int PlantCount { get; set; }
    public string? LocationName { get; set; }
    public string StrainName { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public DateTimeOffset ActualDate { get; set; }
}