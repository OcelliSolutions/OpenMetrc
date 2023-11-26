namespace OpenMetrc.V2;

public partial class MetrcService : IPlantClient
{
    [MapsToApi(MetrcEndpoint.get_plants_v2_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_vegetative)]
    Task<PlantMetrcWrapper> IPlantClient.GetPlantVegetativeAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetPlantVegetativeAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_flowering)]
    Task<PlantMetrcWrapper> IPlantClient.GetPlantFloweringAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetPlantFloweringAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_onhold)]
    Task<PlantMetrcWrapper> IPlantClient.GetPlantOnHoldAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetPlantOnHoldAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_inactive)]
    Task<PlantMetrcWrapper> IPlantClient.GetPlantInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetPlantInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives)]
    Task<PlantAdditiveMetrcWrapper> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantAdditiveMetrcWrapper())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives)]
    Task IPlantClient.PostPlantAdditivesAsync(string licenseNumber, IEnumerable<PostPlantAdditivesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantAdditivesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_growthphases)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_tag)]
    Task IPlantClient.PutPlantTagAsync(string licenseNumber, IEnumerable<PutPlantTagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantTagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_strain)]
    Task IPlantClient.PutPlantStrainAsync(string licenseNumber, IEnumerable<PutPlantStrainRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantStrainAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives_types)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantAdditiveTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantAdditiveTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_methods_all)]
    Task<PlantWasteMethodMetrcWrapper> IPlantClient.GetPlantWasteMethodAllAsync(int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteMethodMetrcWrapper())
            : PlantClient.GetPlantWasteMethodAllAsync(pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_split)]
    Task IPlantClient.PutPlantSplitAsync(string licenseNumber, IEnumerable<PutPlantSplitRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantSplitAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_reasons)]
    Task<PlantWasteReasonMetrcWrapper> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteReasonMetrcWrapper())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_location)]
    Task IPlantClient.PutPlantLocationAsync(string licenseNumber, IEnumerable<PutPlantLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_growthphase)]
    Task IPlantClient.PutPlantGrowthPhaseAsync(string licenseNumber,
        IEnumerable<PutPlantGrowthPhaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantGrowthPhaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plants_v2)]
    Task IPlantClient.DeletePlantsAsync(string licenseNumber, IEnumerable<DeletePlantsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_waste)]
    Task IPlantClient.PostPlantWasteAsync(string licenseNumber, IEnumerable<PostPlantWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives_bylocation)]
    Task IPlantClient.PostPlantAdditiveByLocationAsync(string licenseNumber,
        IEnumerable<PostPlantAdditiveByLocationRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantAdditiveByLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantings)]
    Task IPlantClient.PostPlantPlantingsAsync(string licenseNumber, IEnumerable<PostPlantPlantingsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantPlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantbatch_packages)]
    Task IPlantClient.PostPlantPlantBatchPackagesAsync(string licenseNumber,
        IEnumerable<PostPlantPlantBatchPackagesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantPlantBatchPackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_harvest)]
    Task IPlantClient.PutPlantHarvestAsync(string licenseNumber, IEnumerable<PutPlantHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_merge)]
    Task IPlantClient.PutPlantMergeAsync(string licenseNumber, IEnumerable<PutPlantMergeRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PutPlantMergeAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_manicure)]
    Task IPlantClient.PostPlantManicureAsync(string licenseNumber, IEnumerable<PostPlantManicureRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.PostPlantManicureAsync(licenseNumber, body, cancellationToken);
}