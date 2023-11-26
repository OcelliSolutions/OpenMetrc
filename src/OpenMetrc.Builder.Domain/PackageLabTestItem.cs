namespace OpenMetrc.Builder.Domain;

public class PackageLabTestItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? ProductCategoryName { get; set; }
    public int? ProductCategoryType { get; set; }
    public bool? IsExpirationDateRequired { get; set; }
    public bool? IsSellByDateRequired { get; set; }
    public bool? IsUseByDateRequired { get; set; }
    public int? QuantityType { get; set; }
    public int? DefaultLabTestingState { get; set; }
    public string? UnitOfMeasureName { get; set; }
    public int? ApprovalStatus { get; set; }
    public DateTime? ApprovalStatusDateTime { get; set; }
    public long? StrainId { get; set; }
    public string? StrainName { get; set; }
    public long? ItemBrandId { get; set; }
    public string? ItemBrandName { get; set; }
    public string? AdministrationMethod { get; set; }
    public string? UnitCbdPercent { get; set; }
    public string? UnitCbdContent { get; set; }
    public string? UnitCbdContentUnitOfMeasureName { get; set; }
    public string? UnitCbdContentDose { get; set; }
    public string? UnitCbdContentDoseUnitOfMeasureName { get; set; }
    public string? UnitThcPercent { get; set; }
    public string? UnitThcContent { get; set; }
    public string? UnitThcContentUnitOfMeasureName { get; set; }
    public string? UnitThcContentDose { get; set; }
    public string? UnitThcContentDoseUnitOfMeasureName { get; set; }
    public string? UnitVolume { get; set; }
    public string? UnitVolumeUnitOfMeasureName { get; set; }
    public string? UnitWeight { get; set; }
    public string? UnitWeightUnitOfMeasureName { get; set; }
    public string? ServingSize { get; set; }
    public int? SupplyDurationDays { get; set; }
    public int? NumberOfDoses { get; set; }
    public int? UnitQuantity { get; set; }
    public string? UnitQuantityUnitOfMeasureName { get; set; }
    public string? PublicIngredients { get; set; }
    public string? Description { get; set; }
    public string? Allergens { get; set; }
    public string[]? ProductImages { get; set; }
    public string? ProductPhotoDescription { get; set; }
    public string[]? LabelImages { get; set; }
    public string? LabelPhotoDescription { get; set; }
    public string[]? PackagingImages { get; set; }
    public string? PackagingPhotoDescription { get; set; }
    public bool? IsUsed { get; set; }
}