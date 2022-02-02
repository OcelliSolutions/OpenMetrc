namespace OpenMetrc.Builder.Models;

public class Plant
{
    public int Id { get; set; }
    [MaxLength(100)] public string? Label { get; set; }
    [MaxLength(100)] public string? State { get; set; }
    [MaxLength(100)] public string? GrowthPhase { get; set; }
    public int? PlantBatchId { get; set; }
    [MaxLength(100)] public string? PlantBatchName { get; set; }
    public int? PlantBatchTypeId { get; set; }
    [MaxLength(100)] public string? PlantBatchTypeName { get; set; }
    public int? StrainId { get; set; }
    [MaxLength(100)] public string? StrainName { get; set; }
    public int? LocationId { get; set; }
    [MaxLength(100)] public string? LocationName { get; set; }
    [MaxLength(100)] public string? LocationTypeName { get; set; }
    public int? RoomId { get; set; }
    [MaxLength(100)] public string? RoomName { get; set; }
    [MaxLength(100)] public string? PatientLicenseNumber { get; set; }
    public int? HarvestId { get; set; }
    [MaxLength(100)] public string? HarvestedUnitOfWeightName { get; set; }
    [MaxLength(100)] public string? HarvestedUnitOfWeightAbbreviation { get; set; }
    public double? HarvestedWetWeight { get; set; }
    public int? HarvestCount { get; set; }
    public bool IsOnHold { get; set; }
    public DateTime? PlantedDate { get; set; }
    public DateTime? VegetativeDate { get; set; }
    public DateTime? FloweringDate { get; set; }
    public DateTime? HarvestedDate { get; set; }
    public DateTime? DestroyedDate { get; set; }
    public string? DestroyedNote { get; set; }
    [MaxLength(100)] public string? DestroyedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
}