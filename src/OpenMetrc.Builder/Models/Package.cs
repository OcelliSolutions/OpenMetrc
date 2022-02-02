namespace OpenMetrc.Builder.Models;

public class Package
{
    public int Id { get; set; }
    [MaxLength(100)] public string? Label { get; set; }
    [MaxLength(100)] public string? PackageType { get; set; }
    public string? SourceHarvestNames { get; set; }
    public int? LocationId { get; set; }
    [MaxLength(100)] public string? LocationName { get; set; }
    [MaxLength(100)] public string? LocationTypeName { get; set; }
    public int? RoomId { get; set; }
    [MaxLength(100)] public string? RoomName { get; set; }
    public double? Quantity { get; set; }
    [MaxLength(100)] public string? UnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? UnitOfMeasureAbbreviation { get; set; }
    [MaxLength(100)] public string? PatientLicenseNumber { get; set; }
    [MaxLength(100)] public string? ItemFromFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? ItemFromFacilityName { get; set; }
    public string? Note { get; set; }
    public DateTime? PackagedDate { get; set; }
    [MaxLength(100)] public string? InitialLabTestingState { get; set; }
    [MaxLength(100)] public string? LabTestingState { get; set; }
    public DateTime? LabTestingStateDate { get; set; }
    public bool IsProductionBatch { get; set; }
    [MaxLength(100)] public string? ProductionBatchNumber { get; set; }
    [MaxLength(100)] public string? SourceProductionBatchNumbers { get; set; }
    public bool? IsTradeSample { get; set; }
    public bool? IsDonation { get; set; }
    public bool? IsDonationPersistent { get; set; }
    public bool? SourcePackageIsDonation { get; set; }
    public bool? SourcePackageIsTradeSample { get; set; }
    public bool? IsTestingSample { get; set; }
    public bool? IsProcessValidationTestingSample { get; set; }
    public bool? IsTradeSamplePersistent { get; set; }
    public bool? ProductRequiresRemediation { get; set; }
    public bool? ContainsRemediatedProduct { get; set; }
    public DateTime? RemediationDate { get; set; }
    public DateTime? ReceivedDateTime { get; set; }
    [MaxLength(100)] public string? ReceivedFromManifestNumber { get; set; }
    [MaxLength(100)] public string? ReceivedFromFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? ReceivedFromFacilityName { get; set; }
    public bool IsOnHold { get; set; }
    public DateTime? ArchivedDate { get; set; }
    public DateTime? FinishedDate { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public Item? Item { get; set; }
}