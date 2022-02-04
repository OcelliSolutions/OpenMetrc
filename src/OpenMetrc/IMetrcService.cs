namespace OpenMetrc;

public interface IMetrcService
{
    /// <summary>
    ///     METRC is not in all states and not all states have the same endpoint. If this value is true, an empty result will
    ///     be returned instead of a `ReturnEmptyOnNotSupported` exception
    /// </summary>
    bool ReturnEmptyOnNotSupported { get; set; }

    string State { get; set; }
    bool IsSandbox { get; set; }
    string SoftwareApiKey { get; set; }
    string UserApiKey { get; set; }
    IEmployee Employees { get; }
    IFacility Facilities { get; }
    IHarvest Harvests { get; }
    IItem Items { get; }
    ILabTest LabTests { get; }
    ILocation Locations { get; }
    IPackage Packages { get; }
    IPatient Patients { get; }
    IPlant Plants { get; }
    IPlantBatch PlantBatches { get; }
    ISaleReceipt SaleReceipts { get; }
    ISaleTransaction SaleTransactions { get; }
    IStrain Strains { get; }
    ITransfer Transfers { get; }
    IUnitOfMeasure UnitOfMeasures { get; }
}