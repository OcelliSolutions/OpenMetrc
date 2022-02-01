namespace OpenMetrc.Builder.Models;

public class ItemBase
{
    [MaxLength(500)] public string? Name { get; set; }
    [MaxLength(100)] public string? ProductCategoryName { get; set; }
    [MaxLength(100)] public string? ProductCategoryType { get; set; }
    [MaxLength(100)] public string? QuantityType { get; set; }
    [MaxLength(100)] public string? DefaultLabTestingState { get; set; }
    [MaxLength(100)] public string? UnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? ApprovalStatus { get; set; }
    public DateTimeOffset? ApprovalStatusDateTime { get; set; }
    public int? StrainId { get; set; }
    [MaxLength(100)] public string? StrainName { get; set; }
    [MaxLength(100)] public string? AdministrationMethod { get; set; }
    public double? UnitCbdPercent { get; set; }
    public double? UnitCbdContent { get; set; }
    [MaxLength(100)] public string? UnitCbdContentUnitOfMeasureName { get; set; }
    public double? UnitCbdContentDose { get; set; }
    [MaxLength(100)] public string? UnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? UnitThcPercent { get; set; }
    public double? UnitThcContent { get; set; }
    [MaxLength(100)] public string? UnitThcContentUnitOfMeasureName { get; set; }
    public double? UnitThcContentDose { get; set; }
    [MaxLength(100)] public string? UnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? UnitVolume { get; set; }
    [MaxLength(100)] public string? UnitVolumeUnitOfMeasureName { get; set; }
    public double? UnitWeight { get; set; }
    [MaxLength(100)] public string? UnitWeightUnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? ServingSize { get; set; }
    public int? SupplyDurationDays { get; set; }
    public int? NumberOfDoses { get; set; }
    public double? UnitQuantity { get; set; }
    [MaxLength(100)] public string? UnitQuantityUnitOfMeasureName { get; set; }
    public string? Ingredients { get; set; }
    public string? Description { get; set; }
    public bool? IsUsed { get; set; }
    public string? PublicIngredients { get; set; }
}
