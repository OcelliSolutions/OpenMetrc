namespace OpenMetrc.V2;

public partial class MetrcService : IPlantBatchClient
{
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_id)]
    Task<PlantBatch> IPlantBatchClient.GetPlantBatchByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : PlantBatchClient.GetPlantBatchByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_id)]
    Task<PlantBatch> IPlantBatchClient.GetPlantBatchByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : PlantBatchClient.GetPlantBatchByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_active)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetActivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetActivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_active)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetActivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetActivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_inactive)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetInactivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetInactivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_inactive)]
    Task<PlantBatchMetrcWrapper> IPlantBatchClient.GetInactivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchMetrcWrapper())
            : PlantBatchClient.GetInactivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_types)]
    Task<StringMetrcWrapper> IPlantBatchClient.GetPlantBatchTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantBatchClient.GetPlantBatchTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_types)]
    Task<StringMetrcWrapper> IPlantBatchClient.GetPlantBatchTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantBatchClient.GetPlantBatchTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_plantings)]
    Task IPlantBatchClient.CreatePlantBatchPlantingsAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchPlantingsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_plantings)]
    Task IPlantBatchClient.CreatePlantBatchPlantingsAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPlantingRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchPlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages)]
    Task IPlantBatchClient.CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchPackagesAsync(licenseNumber, isFromMotherPlant, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages)]
    Task IPlantBatchClient.CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchPackagesAsync(licenseNumber, isFromMotherPlant, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_split)]
    Task IPlantBatchClient.SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.SplitPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_split)]
    Task IPlantBatchClient.SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.SplitPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant)]
    Task IPlantBatchClient.CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePackageFromPlantBatchMotherPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant)]
    Task IPlantBatchClient.CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePackageFromPlantBatchMotherPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_growthphase)]
    Task IPlantBatchClient.ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.ChangeGrowthPhaseForPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_growthphase)]
    Task IPlantBatchClient.ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.ChangeGrowthPhaseForPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_tag)]
    Task IPlantBatchClient.TagPlantBatchAsync(string licenseNumber, IEnumerable<TagPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.TagPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_tag)]
    Task IPlantBatchClient.TagPlantBatchAsync(string licenseNumber, IEnumerable<TagPlantBatchRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.TagPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_strain)]
    Task IPlantBatchClient.UpdatePlantBatchStrainAsync(string licenseNumber, IEnumerable<UpdatePlantBatchStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.UpdatePlantBatchStrainAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_strain)]
    Task IPlantBatchClient.UpdatePlantBatchStrainAsync(string licenseNumber, IEnumerable<UpdatePlantBatchStrainRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.UpdatePlantBatchStrainAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_location)]
    Task IPlantBatchClient.MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.MovePlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_location)]
    Task IPlantBatchClient.MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.MovePlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_additives)]
    Task IPlantBatchClient.AddAdditiveToPlantBatchAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.AddAdditiveToPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_additives)]
    Task IPlantBatchClient.AddAdditiveToPlantBatchAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantBatchRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.AddAdditiveToPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plantbatches_v2)]
    Task IPlantBatchClient.DeletePlantBatchesAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.DeletePlantBatchesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.delete_plantbatches_v2)]
    Task IPlantBatchClient.DeletePlantBatchesAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.DeletePlantBatchesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_waste_reasons)]
    Task<PlantBatchWasteReasonMetrcWrapper> IPlantBatchClient.GetPlantBatchWasteReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchWasteReasonMetrcWrapper())
            : PlantBatchClient.GetPlantBatchWasteReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_waste_reasons)]
    Task<PlantBatchWasteReasonMetrcWrapper> IPlantBatchClient.GetPlantBatchWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatchWasteReasonMetrcWrapper())
            : PlantBatchClient.GetPlantBatchWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_waste)]
    Task IPlantBatchClient.CreatePlantBatchWasteAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_waste)]
    Task IPlantBatchClient.CreatePlantBatchWasteAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchWasteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.CreatePlantBatchWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_adjust)]
    Task IPlantBatchClient.AdjustPlantBatchAsync(string licenseNumber, IEnumerable<AdjustPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.AdjustPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_adjust)]
    Task IPlantBatchClient.AdjustPlantBatchAsync(string licenseNumber, IEnumerable<AdjustPlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantBatchClient.AdjustPlantBatchAsync(licenseNumber, body, cancellationToken);
}