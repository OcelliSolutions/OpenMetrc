namespace OpenMetrc.Builder.Models;

public class PlantBatch
{
    [Required] public long Id { get; set; }

    public string? Name { get; set; }
    public int? PlantBatchTypeId { get; set; }
    public string? PlantBatchTypeName { get; set; }
    public string? Type { get; set; }
    public int? LocationId { get; set; }
    public string? LocationName { get; set; }
    public string? LocationTypeName { get; set; }
    public int? RoomId { get; set; }
    public string? RoomName { get; set; }
    public int? StrainId { get; set; }
    public string? StrainName { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public int? Count { get; set; }
    public int? UntrackedCount { get; set; }
    public int? TrackedCount { get; set; }
    public int? LiveCount { get; set; }
    public int? PackagedCount { get; set; }
    public int? HarvestedCount { get; set; }
    public int? DestroyedCount { get; set; }
    public int? SourcePackageId { get; set; }
    public string? SourcePackageLabel { get; set; }
    public int? SourcePlantId { get; set; }
    public string? SourcePlantLabel { get; set; }
    public int? SourcePlantBatchId { get; set; }
    public string? SourcePlantBatchName { get; set; }
    public int[]? SourcePlantBatchIds { get; set; }
    public string? SourcePlantBatchNames { get; set; }
    public bool? MultiPlantBatch { get; set; }
    public DateTime? PlantedDate { get; set; }
    public DateTimeOffset LastModified { get; set; }
}