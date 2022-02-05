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
    IEmployeeClient Employees { get; }
    IFacilityClient Facilities { get; }
    IHarvestClient Harvests { get; }
    IItemClient Items { get; }
    ILabTestClient LabTests { get; }
    ILocationClient Locations { get; }
    IPackageClient Packages { get; }
    IPatientClient Patients { get; }
    IPlantClient Plants { get; }
    IPlantBatchClient PlantBatches { get; }
    ISaleClient Sales { get; }
    IStrainClient Strains { get; }
    ITransferClient Transfers { get; }
    IUnitOfMeasureClient UnitOfMeasures { get; }
}