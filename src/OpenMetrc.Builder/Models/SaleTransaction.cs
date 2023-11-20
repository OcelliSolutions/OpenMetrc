namespace OpenMetrc.Builder.Models;

public class SaleTransaction
{
    public long PackageId { get; set; }
    public string? PackageLabel { get; set; }
    public string? ProductName { get; set; }
    public string? ProductCategoryName { get; set; }
    public string? ItemStrainName { get; set; }
    public double? ItemUnitCbdPercent { get; set; }
    public double? ItemUnitCbdContent { get; set; }
    public string? ItemUnitCbdContentUnitOfMeasureName { get; set; }
    public double? ItemUnitCbdContentDose { get; set; }
    public string? ItemUnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitThcPercent { get; set; }
    public double? ItemUnitThcContent { get; set; }
    public string? ItemUnitThcContentUnitOfMeasureName { get; set; }
    public double? ItemUnitThcContentDose { get; set; }
    public string? ItemUnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? ItemUnitVolume { get; set; }
    public string? ItemUnitVolumeUnitOfMeasureName { get; set; }
    public double? ItemUnitWeight { get; set; }
    public string? ItemUnitWeightUnitOfMeasureName { get; set; }
    public string? ItemServingSize { get; set; }
    public int? ItemSupplyDurationDays { get; set; }
    public double? ItemUnitQuantity { get; set; }
    public string? ItemUnitQuantityUnitOfMeasureName { get; set; }
    public double QuantitySold { get; set; }
    public string? UnitOfMeasureName { get; set; }
    public string? UnitOfMeasureAbbreviation { get; set; }
    public double TotalPrice { get; set; }
    public string? SalesDeliveryState { get; set; }
    public DateTimeOffset? ArchivedDate { get; set; }
    public DateTimeOffset? RecordedDateTime { get; set; }
    public string? RecordedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
}