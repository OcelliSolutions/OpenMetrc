namespace OpenMetrc.V1;

public interface IMetrcService
{   
    OpenMetrcConfig OpenMetrcConfig { get; set; }
    IEnumerable<string> AvailableStates { get; }
    IEmployeeClient Employees { get; }
    IFacilityClient Facilities { get; }
    IHarvestClient Harvests { get; }
    IItemClient Items { get; }
    ILabTestClient LabTests { get; }
    ILocationClient Locations { get; }
    IPackageClient Packages { get; }
    IPatientClient Patients { get; }
    IPatientStatusClient PatientsStatus { get; }
    IPlantClient Plants { get; }
    IPlantBatchClient PlantBatches { get; }
    ISaleClient Sales { get; }
    IStrainClient Strains { get; }
    ITransferClient Transfers { get; }
    IUnitOfMeasureClient UnitOfMeasures { get; }
}