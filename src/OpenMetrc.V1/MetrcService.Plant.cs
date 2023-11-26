namespace OpenMetrc.V1;

public partial class MetrcService : IPlantClient
{
    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    Task<ICollection<Plant>?> IPlantClient.GetPlantVegetativeAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetPlantVegetativeAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    Task<ICollection<Plant>?> IPlantClient.GetPlantFloweringAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetPlantFloweringAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    Task<ICollection<Plant>?> IPlantClient.GetPlantOnHoldAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetPlantOnHoldAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    Task<ICollection<Plant>?> IPlantClient.GetPlantInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetPlantInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    Task<ICollection<PlantAdditive>?> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantAdditive>?>(new List<PlantAdditive>())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    Task IPlantClient.PostPlantAdditivesAsync(string licenseNumber, IEnumerable<PostPlantAdditivesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantAdditivesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    Task<ICollection<string>> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    Task<ICollection<string>> IPlantClient.GetPlantAdditiveTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantAdditiveTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods_all)]
    Task<ICollection<PlantWasteMethod>?> IPlantClient.GetPlantWasteMethodAllAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteMethod>?>(new List<PlantWasteMethod>())
            : PlantClient.GetPlantWasteMethodAllAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    Task<ICollection<PlantWasteReason>?> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteReason>?>(new List<PlantWasteReason>())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    Task IPlantClient.PostPlantMovePlantsAsync(string licenseNumber, IEnumerable<PostPlantMovePlantsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantMovePlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    Task IPlantClient.PostPlantChangeGrowthPhasesAsync(string licenseNumber,
        IEnumerable<PostPlantChangeGrowthPhasesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantChangeGrowthPhasesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plants_v1)]
    Task IPlantClient.DeletePlantsAsync(string licenseNumber, IEnumerable<DeletePlantsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_waste)]
    Task IPlantClient.PostPlantWasteAsync(string licenseNumber, IEnumerable<PostPlantWasteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    Task IPlantClient.PostPlantAdditiveByLocationAsync(string licenseNumber,
        IEnumerable<PostPlantAdditiveByLocationRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantAdditiveByLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    Task IPlantClient.PostPlantCreatePlantingsAsync(string licenseNumber,
        IEnumerable<PostPlantCreatePlantingsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantCreatePlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    Task IPlantClient.PostPlantCreatePlantBatchPackagesAsync(string licenseNumber,
        IEnumerable<PostPlantCreatePlantBatchPackagesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantCreatePlantBatchPackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    Task IPlantClient.PostPlantHarvestPlantsAsync(string licenseNumber, IEnumerable<PostPlantHarvestPlantsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantHarvestPlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    Task IPlantClient.PostPlantManicurePlantsAsync(string licenseNumber, IEnumerable<PostPlantManicurePlantsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantManicurePlantsAsync(licenseNumber, body, cancellationToken);
}