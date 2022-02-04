namespace OpenMetrc;

public partial class MetrcService : IPlantBatch
{
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
    Task<PlantBatch> IPlantBatch.GetPlantBatchByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : UserMetrcClient.GetPlantBatchByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
    Task<PlantBatch> IPlantBatch.GetPlantBatchByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantBatch())
            : UserMetrcClient.GetPlantBatchByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    Task<ICollection<PlantBatch>> IPlantBatch.GetActivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>>(new List<PlantBatch>())
            : UserMetrcClient.GetActivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    Task<ICollection<PlantBatch>> IPlantBatch.GetActivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>>(new List<PlantBatch>())
            : UserMetrcClient.GetActivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    Task<ICollection<PlantBatch>> IPlantBatch.GetInactivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>>(new List<PlantBatch>())
            : UserMetrcClient.GetInactivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    Task<ICollection<PlantBatch>> IPlantBatch.GetInactivePlantBatchesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantBatch>>(new List<PlantBatch>())
            : UserMetrcClient.GetInactivePlantBatchesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    Task<ICollection<string>> IPlantBatch.GetPlantBatchTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantBatchTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    Task<ICollection<string>> IPlantBatch.GetPlantBatchTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantBatchTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    Task IPlantBatch.CreatePlantBatchPlantingsAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPlantingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchPlantingsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    Task IPlantBatch.CreatePlantBatchPlantingsAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPlantingRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchPlantingsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    Task IPlantBatch.CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchPackagesAsync(licenseNumber, isFromMotherPlant, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    Task IPlantBatch.CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchPackagesAsync(licenseNumber, isFromMotherPlant, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    Task IPlantBatch.SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.SplitPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    Task IPlantBatch.SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.SplitPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    Task IPlantBatch.CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageFromPlantBatchMotherPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    Task IPlantBatch.CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageFromPlantBatchMotherPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    Task IPlantBatch.ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangeGrowthPhaseForPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    Task IPlantBatch.ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangeGrowthPhaseForPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    Task IPlantBatch.MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MovePlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    Task IPlantBatch.MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MovePlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    Task IPlantBatch.AddAdditiveToPlantBatchAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    Task IPlantBatch.AddAdditiveToPlantBatchAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantBatchRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantBatchAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_destroy)]
    Task IPlantBatch.DestroyPlantBatchAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DestroyPlantBatchAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_destroy)]
    Task IPlantBatch.DestroyPlantBatchAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DestroyPlantBatchAsync(licenseNumber, body, cancellationToken);
}