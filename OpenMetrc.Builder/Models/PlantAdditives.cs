using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Models;

public class PlantAdditive
{
    [MaxLength(100)] public string? AdditiveTypeName { get; set; }
    [MaxLength(100)] public string? ProductTradeName { get; set; }
    [MaxLength(100)] public string? EpaRegistrationNumber { get; set; }
    [MaxLength(100)] public string? ProductSupplier { get; set; }
    [MaxLength(100)] public string? ApplicationDevice { get; set; }
    [MaxLength(100)] public string? AmountUnitOfMeasure { get; set; }
    public double? TotalAmountApplied { get; set; }
    public int? PlantBatchId { get; set; }
    [MaxLength(100)] public string? PlantBatchName { get; set; }
    public int? PlantCount { get; set; }
}
