﻿namespace OpenMetrc.V2;

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
    ITagClient Tags { get; }
    ITransferClient Transfers { get; }
    ITransporterClient Transporters { get; }
    IUnitOfMeasureClient UnitOfMeasures { get; }
    IWasteMethodClient WasteMethods { get; }
}