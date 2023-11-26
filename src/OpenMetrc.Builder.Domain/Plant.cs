namespace OpenMetrc.Builder.Domain;

public class Plant
{
    [Required] public long Id { get; set; }

    public string? Label { get; set; }
    public string? State { get; set; }
    public string? GrowthPhase { get; set; }
    public int? PlantBatchId { get; set; }
    public string? PlantBatchName { get; set; }
    public int? PlantBatchTypeId { get; set; }
    public string? PlantBatchTypeName { get; set; }
    public int? StrainId { get; set; }
    public string? StrainName { get; set; }
    public int? LocationId { get; set; }
    public string? LocationName { get; set; }
    public string? LocationTypeName { get; set; }
    public int? RoomId { get; set; }
    public string? RoomName { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public int? HarvestId { get; set; }
    public string? HarvestedUnitOfWeightName { get; set; }
    public string? HarvestedUnitOfWeightAbbreviation { get; set; }
    public double? HarvestedWetWeight { get; set; }
    public int? HarvestCount { get; set; }
    public bool IsOnHold { get; set; }
    public DateTime? PlantedDate { get; set; }
    public DateTime? VegetativeDate { get; set; }
    public DateTime? FloweringDate { get; set; }
    public DateTime? HarvestedDate { get; set; }
    public DateTime? DestroyedDate { get; set; }
    public string? DestroyedNote { get; set; }
    public string? DestroyedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public int? GroupTagTypeMax { get; set; }
    public bool? IsOnTrip { get; set; }
}