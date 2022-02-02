namespace OpenMetrc.Builder.Models;

public class PlantBatch
{
    public int Id { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    public int? PlantBatchTypeId { get; set; }
    [MaxLength(100)] public string? PlantBatchTypeName { get; set; }
    [MaxLength(100)] public string? Type { get; set; }
    public int? LocationId { get; set; }
    [MaxLength(100)] public string? LocationName { get; set; }
    [MaxLength(100)] public string? LocationTypeName { get; set; }
    public int? RoomId { get; set; }
    [MaxLength(100)] public string? RoomName { get; set; }
    public int? StrainId { get; set; }
    [MaxLength(100)] public string? StrainName { get; set; }
    [MaxLength(100)] public string? PatientLicenseNumber { get; set; }
    public int? Count { get; set; }
    public int? UntrackedCount { get; set; }
    public int? TrackedCount { get; set; }
    public int? LiveCount { get; set; }
    public int? PackagedCount { get; set; }
    public int? HarvestedCount { get; set; }
    public int? DestroyedCount { get; set; }
    public int? SourcePackageId { get; set; }
    [MaxLength(100)] public string? SourcePackageLabel { get; set; }
    public int? SourcePlantId { get; set; }
    [MaxLength(100)] public string? SourcePlantLabel { get; set; }
    public int? SourcePlantBatchId { get; set; }
    [MaxLength(100)] public string? SourcePlantBatchName { get; set; }
    public DateTime? PlantedDate { get; set; }
    public DateTimeOffset LastModified { get; set; }
}