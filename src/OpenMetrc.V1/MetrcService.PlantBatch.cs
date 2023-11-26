namespace OpenMetrc.V1;

public partial class MetrcService : IPlantBatchClient
{
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
    Task<PlantBatch> IPlantBatchClient.GetPlantBatchByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : PlantBatchClient.GetPlantBatchByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
    Task<PlantBatch> IPlantBatchClient.GetPlantBatchByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : PlantBatchClient.GetPlantBatchByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    Task<ICollection<PlantBatch>?> IPlantBatchClient.GetPlantBatchActiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>?>(new List<PlantBatch>())
            : PlantBatchClient.GetPlantBatchActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    Task<ICollection<PlantBatch>?> IPlantBatchClient.GetPlantBatchActiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>?>(new List<PlantBatch>())
            : PlantBatchClient.GetPlantBatchActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    Task<ICollection<PlantBatch>?> IPlantBatchClient.GetPlantBatchInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>?>(new List<PlantBatch>())
            : PlantBatchClient.GetPlantBatchInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    Task<ICollection<PlantBatch>?> IPlantBatchClient.GetPlantBatchInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>?>(new List<PlantBatch>())
            : PlantBatchClient.GetPlantBatchInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    Task<ICollection<string>> IPlantBatchClient.GetPlantBatchTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantBatchClient.GetPlantBatchTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    Task<ICollection<string>> IPlantBatchClient.GetPlantBatchTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantBatchClient.GetPlantBatchTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    Task IPlantBatchClient.PostPlantBatchCreatePlantingsAsync(string licenseNumber,
        IEnumerable<PostPlantBatchCreatePlantingsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePlantingsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    Task IPlantBatchClient.PostPlantBatchCreatePlantingsAsync(string licenseNumber,
        IEnumerable<PostPlantBatchCreatePlantingsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    Task IPlantBatchClient.PostPlantBatchCreatePackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<PostPlantBatchCreatePackagesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePackagesAsync(licenseNumber, isFromMotherPlant, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    Task IPlantBatchClient.PostPlantBatchCreatePackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<PostPlantBatchCreatePackagesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePackagesAsync(licenseNumber, isFromMotherPlant, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    Task IPlantBatchClient.PostPlantBatchSplitAsync(string licenseNumber, IEnumerable<PostPlantBatchSplitRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchSplitAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    Task IPlantBatchClient.PostPlantBatchSplitAsync(string licenseNumber, IEnumerable<PostPlantBatchSplitRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchSplitAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    Task IPlantBatchClient.PostPlantBatchCreatePackageFromMotherPlantAsync(string licenseNumber,
        IEnumerable<PostPlantBatchCreatePackageFromMotherPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePackageFromMotherPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    Task IPlantBatchClient.PostPlantBatchCreatePackageFromMotherPlantAsync(string licenseNumber,
        IEnumerable<PostPlantBatchCreatePackageFromMotherPlantRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchCreatePackageFromMotherPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    Task IPlantBatchClient.PostPlantBatchChangeGrowthPhaseAsync(string licenseNumber,
        IEnumerable<PostPlantBatchChangeGrowthPhaseRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchChangeGrowthPhaseAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    Task IPlantBatchClient.PostPlantBatchChangeGrowthPhaseAsync(string licenseNumber,
        IEnumerable<PostPlantBatchChangeGrowthPhaseRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchChangeGrowthPhaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    Task IPlantBatchClient.PutPlantBatchMovePlantBatchesAsync(string licenseNumber, IEnumerable<PutPlantBatchMovePlantBatchesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PutPlantBatchMovePlantBatchesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    Task IPlantBatchClient.PutPlantBatchMovePlantBatchesAsync(string licenseNumber, IEnumerable<PutPlantBatchMovePlantBatchesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PutPlantBatchMovePlantBatchesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    Task IPlantBatchClient.PostPlantBatchAdditivesAsync(string licenseNumber,
        IEnumerable<PostPlantBatchAdditivesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdditivesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    Task IPlantBatchClient.PostPlantBatchAdditivesAsync(string licenseNumber,
        IEnumerable<PostPlantBatchAdditivesRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdditivesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plantbatches_v1)]
    Task IPlantBatchClient.DeletePlantBatchesAsync(string licenseNumber, IEnumerable<DeletePlantBatchesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.DeletePlantBatchesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.delete_plantbatches_v1)]
    Task IPlantBatchClient.DeletePlantBatchesAsync(string licenseNumber, IEnumerable<DeletePlantBatchesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.DeletePlantBatchesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_waste_reasons)]
    Task<ICollection<PlantBatchWasteReason>?> IPlantBatchClient.GetPlantBatchWasteReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatchWasteReason>?>(new List<PlantBatchWasteReason>())
            : PlantBatchClient.GetPlantBatchWasteReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_waste_reasons)]
    Task<ICollection<PlantBatchWasteReason>?> IPlantBatchClient.GetPlantBatchWasteReasonsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatchWasteReason>?>(new List<PlantBatchWasteReason>())
            : PlantBatchClient.GetPlantBatchWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_waste)]
    Task IPlantBatchClient.PostPlantBatchWasteAsync(string licenseNumber, IEnumerable<PostPlantBatchWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_waste)]
    Task IPlantBatchClient.PostPlantBatchWasteAsync(string licenseNumber, IEnumerable<PostPlantBatchWasteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_adjust)]
    Task IPlantBatchClient.PostPlantBatchAdjustAsync(string licenseNumber, IEnumerable<PostPlantBatchAdjustRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdjustAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_adjust)]
    Task IPlantBatchClient.PostPlantBatchAdjustAsync(string licenseNumber, IEnumerable<PostPlantBatchAdjustRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.PostPlantBatchAdjustAsync(licenseNumber, body, cancellationToken);
}