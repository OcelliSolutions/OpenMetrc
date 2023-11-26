namespace OpenMetrc.Builder.Domain;

public class LabTest
{
    public long PackageId { get; set; }
    public long LabTestResultId { get; set; }
    public string? LabFacilityLicenseNumber { get; set; }
    public string? LabFacilityName { get; set; }
    public string? SourcePackageLabel { get; set; }
    public string? ProductName { get; set; }
    public string? ProductCategoryName { get; set; }
    public DateTime? TestPerformedDate { get; set; }
    public bool? OverallPassed { get; set; }
    public DateTime? RevokedDate { get; set; }
    public bool? ResultReleased { get; set; }
    public DateTimeOffset? ResultReleaseDateTime { get; set; }
    public string? TestTypeName { get; set; }
    public bool? TestPassed { get; set; }
    public double? TestResultLevel { get; set; }
    public string? TestComment { get; set; }
    public bool? TestInformationalOnly { get; set; }
    public DateTime? LabTestDetailRevokedDate { get; set; }
}