﻿namespace OpenMetrc.Builder.Domain.Requests;

public class CreateItemRequest
{
    public string? Name { get; set; }
    public string? ProductCategoryName { get; set; }
    public string? ProductCategoryType { get; set; }
    public string? QuantityType { get; set; }
    public string? DefaultLabTestingState { get; set; }
    public string? UnitOfMeasureName { get; set; }
    public string? ApprovalStatus { get; set; }
    public DateTimeOffset? ApprovalStatusDateTime { get; set; }
    public int? StrainId { get; set; }
    public string? StrainName { get; set; }
    public string? AdministrationMethod { get; set; }
    public double? UnitCbdPercent { get; set; }
    public double? UnitCbdContent { get; set; }
    public string? UnitCbdContentUnitOfMeasureName { get; set; }
    public double? UnitCbdContentDose { get; set; }
    public string? UnitCbdContentDoseUnitOfMeasureName { get; set; }
    public double? UnitThcPercent { get; set; }
    public double? UnitThcContent { get; set; }
    public string? UnitThcContentUnitOfMeasureName { get; set; }
    public double? UnitThcContentDose { get; set; }
    public string? UnitThcContentDoseUnitOfMeasureName { get; set; }
    public double? UnitVolume { get; set; }
    public string? UnitVolumeUnitOfMeasureName { get; set; }
    public double? UnitWeight { get; set; }
    public string? UnitWeightUnitOfMeasureName { get; set; }
    public string? ServingSize { get; set; }
    public int? SupplyDurationDays { get; set; }
    public int? NumberOfDoses { get; set; }
    public double? UnitQuantity { get; set; }
    public string? UnitQuantityUnitOfMeasureName { get; set; }
    public string? Ingredients { get; set; }
    public string? Description { get; set; }
    public bool? IsUsed { get; set; }
    public string? PublicIngredients { get; set; }
}