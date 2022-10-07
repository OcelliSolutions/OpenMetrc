namespace OpenMetrc.Builder.Models.Requests;

public class CreateProcessingPackageRequest
{
    public string? JobName { get; set; }
    public string? Tag { get; set; }
    public string? Location { get; set; }
    public string? Item { get; set; }
    public double? Quantity { get; set; }
    public string? UnitOfMeasure { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? Note { get; set; }
    public string? ProductionBatchNumber { get; set; }
    public bool FinishProcessingJob { get; set; }
    public DateTime FinishDate { get; set; }
    public int WasteCountQuantity { get; set; }
    public string? WasteCountUnitOfMeasureName { get; set; }
    public double? WasteVolumeQuantity { get; set; }
    public string? WasteVolumeUnitOfMeasureName { get; set; }
    public double? WasteWeightQuantity { get; set; }
    public string? WasteWeightUnitOfMeasureName { get; set; }
    public string? FinishNote { get; set; }
    public DateTime? PackageDate { get; set; }
}
