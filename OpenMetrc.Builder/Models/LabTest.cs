using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class LabTest
{
    public int PackageId { get; set; }
    public int LabTestResultId { get; set; }
    [MaxLength(100)] public string? LabFacilityLicenseNumber { get; set; }
    [MaxLength(100)] public string? LabFacilityName { get; set; }
    [MaxLength(100)] public string? SourcePackageLabel { get; set; }
    [MaxLength(200)] public string? ProductName { get; set; }
    [MaxLength(100)] public string? ProductCategoryName { get; set; }
    public DateTime? TestPerformedDate { get; set; }
    public bool? OverallPassed { get; set; }
    public DateTime? RevokedDate { get; set; }
    public bool? ResultReleased { get; set; }
    public DateTimeOffset? ResultReleaseDateTime { get; set; }
    [MaxLength(100)] public string? TestTypeName { get; set; }
    public bool? TestPassed { get; set; }
    public double? TestResultLevel { get; set; }
    public string? TestComment { get; set; }
    public bool? TestInformationalOnly { get; set; }
    public DateTime? LabTestDetailRevokedDate { get; set; }
}
