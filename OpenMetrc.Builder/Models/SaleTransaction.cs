namespace OpenMetrc.Builder.Models;

public class SaleTransaction
{
    public int PackageId { get; set; }
    [MaxLength(100)] public string? PackageLabel { get; set; }
    [MaxLength(200)] public string? ProductName { get; set; }
    [MaxLength(100)] public string? ProductCategoryName { get; set; }
    [MaxLength(100)] public string? ItemStrainName { get; set; }
    public double? ItemUnitCbdPercent { get; set; }
    public double? ItemUnitCbdContent { get; set; }
    [MaxLength(100)] public string? ItemUnitCbdContentUnitOfMeasureName { get; set; }
    public double? ItemUnitCbdContentDose { get; set; }
    [MaxLength(100)] public string? ItemUnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitThcPercent { get; set; }
    public double? ItemUnitThcContent { get; set; }
    [MaxLength(100)] public string? ItemUnitThcContentUnitOfMeasureName { get; set; }
    public double? ItemUnitThcContentDose { get; set; }
    [MaxLength(100)] public string? ItemUnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitVolume { get; set; }
    [MaxLength(100)] public string? ItemUnitVolumeUnitOfMeasureName { get; set; }
    public double? ItemUnitWeight { get; set; }
    [MaxLength(100)] public string? ItemUnitWeightUnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? ItemServingSize { get; set; }
    public int? ItemSupplyDurationDays { get; set; }
    public double? ItemUnitQuantity { get; set; }
    [MaxLength(100)] public string? ItemUnitQuantityUnitOfMeasureName { get; set; }
    public double QuantitySold { get; set; }
    [MaxLength(100)] public string? UnitOfMeasureName { get; set; }
    [MaxLength(100)] public string? UnitOfMeasureAbbreviation { get; set; }
    public double TotalPrice { get; set; }
    [MaxLength(100)] public string? SalesDeliveryState { get; set; }
    public DateTimeOffset? ArchivedDate { get; set; }
    public DateTimeOffset? RecordedDateTime { get; set; }
    [MaxLength(100)] public string? RecordedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
}
