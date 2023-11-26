namespace OpenMetrc.V2;

public partial class MetrcService : IPlantBatchClient
{
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_id)]
    Task<PlantBatch> IPlantBatchClient.GetPlantBatchByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : PlantBatchClient.GetPlantBatchByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_active)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetPlantBatchActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetPlantBatchActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_inactive)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetPlantBatchInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetPlantBatchInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_types)]
    Task<StringMetrcWrapper> IPlantBatchClient.GetPlantBatchTypesAsync(int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantBatchClient.GetPlantBatchTypesAsync(pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_plantings)]
    Task IPlantBatchClient.PostPlantBatchPlantingsAsync(string licenseNumber,
        IEnumerable<PostPlantBatchPlantingsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchPlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages)]
    Task IPlantBatchClient.PostPlantBatchPackagesAsync(string licenseNumber, 
        IEnumerable<PostPlantBatchPackagesRequest> body, bool? isFromMotherPlant, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchPackagesAsync(licenseNumber, body, isFromMotherPlant, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_split)]
    Task IPlantBatchClient.PostPlantBatchSplitAsync(string licenseNumber, IEnumerable<PostPlantBatchSplitRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchSplitAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant)]
    Task IPlantBatchClient.PostPlantBatchPackageFromMotherPlantAsync(string licenseNumber,
        IEnumerable<PostPlantBatchPackageFromMotherPlantRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchPackageFromMotherPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_growthphase)]
    Task IPlantBatchClient.PostPlantBatchGrowthPhaseAsync(string licenseNumber,
        IEnumerable<PostPlantBatchGrowthPhaseRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchGrowthPhaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_tag)]
    Task IPlantBatchClient.PutPlantBatchTagAsync(string licenseNumber, IEnumerable<PutPlantBatchTagRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PutPlantBatchTagAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_strain)]
    Task IPlantBatchClient.PutPlantBatchStrainAsync(string licenseNumber, IEnumerable<PutPlantBatchStrainRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PutPlantBatchStrainAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_location)]
    Task IPlantBatchClient.PutPlantBatchLocationAsync(string licenseNumber, IEnumerable<PutPlantBatchLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PutPlantBatchLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_additives)]
    Task IPlantBatchClient.PostPlantBatchAdditivesAsync(string licenseNumber,
        IEnumerable<PostPlantBatchAdditivesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdditivesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plantbatches_v2)]
    Task IPlantBatchClient.DeletePlantBatchesAsync(string licenseNumber, IEnumerable<DeletePlantBatchesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.DeletePlantBatchesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_waste_reasons)]
    Task<PlantBatchWasteReasonMetrcWrapper> IPlantBatchClient.GetPlantBatchWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchWasteReasonMetrcWrapper())
            : PlantBatchClient.GetPlantBatchWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_waste)]
    Task IPlantBatchClient.PostPlantBatchWasteAsync(string licenseNumber,
        IEnumerable<PostPlantBatchWasteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_adjust)]
    Task IPlantBatchClient.PostPlantBatchAdjustAsync(string licenseNumber, IEnumerable<PostPlantBatchAdjustRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdjustAsync(licenseNumber, body, cancellationToken);
}