namespace OpenMetrc.Builder.Models.Requests;

public class CreatePackagePlantingRequest
{
    public CreatePackagePlantingRequest()
    {
        PackageLabel = string.Empty;
    }

    [Required] public string PackageLabel { get; set; }

    public double? PackageAdjustmentAmount { get; set; }
    public string? PackageAdjustmentUnitOfMeasureName { get; set; }
    public string? PlantBatchName { get; set; }
    public string? PlantBatchType { get; set; }

    [Required] public int PlantCount { get; set; }

    public string? LocationName { get; set; }
    public string? StrainName { get; set; }
    public string? PatientLicenseNumber { get; set; }

    [Required] public DateTimeOffset PlantedDate { get; set; }

    [Required] public DateTimeOffset UnpackagedDate { get; set; }
}