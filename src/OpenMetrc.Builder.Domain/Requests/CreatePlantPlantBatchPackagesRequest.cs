namespace OpenMetrc.Builder.Domain.Requests;

public class CreatePlantPlantBatchPackagesRequest
{
    public CreatePlantPlantBatchPackagesRequest()
    {
        PlantLabel = string.Empty;
        PackageTag = string.Empty;
        PlantBatchType = string.Empty;
        Item = string.Empty;
        Location = string.Empty;
    }

    public string PlantLabel { get; set; }
    public string PackageTag { get; set; }
    public string PlantBatchType { get; set; }
    public string Item { get; set; }
    public string Location { get; set; }
    public string? Note { get; set; }
    public bool IsTradeSample { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public bool IsDonation { get; set; }
    public int Count { get; set; }
    public DateTime ActualDate { get; set; }
}