namespace OpenMetrc;

public partial class MetrcService : IHarvestClient
{
    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    Task<ICollection<Harvest>> IHarvestClient.GetActiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    Task<ICollection<Harvest>> IHarvestClient.GetActiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    Task<ICollection<Harvest>> IHarvestClient.GetOnHoldHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    Task<ICollection<Harvest>> IHarvestClient.GetOnHoldHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    Task<ICollection<Harvest>> IHarvestClient.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    Task<ICollection<Harvest>> IHarvestClient.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : HarvestClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    Task<ICollection<HarvestWasteType>> IHarvestClient.GetHarvestWasteTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<HarvestWasteType>>(new List<HarvestWasteType>())
            : HarvestClient.GetHarvestWasteTypesAsync();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    Task<ICollection<HarvestWasteType>> IHarvestClient.GetHarvestWasteTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<HarvestWasteType>>(new List<HarvestWasteType>())
            : HarvestClient.GetHarvestWasteTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    Task IHarvestClient.
        CreateHarvestPackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    Task IHarvestClient.CreateHarvestPackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    Task IHarvestClient.CreateHarvestPackageTestingAsync(string licenseNumber,
        IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageTestingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    Task IHarvestClient.CreateHarvestPackageTestingAsync(string licenseNumber,
        IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    Task IHarvestClient.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.MoveHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    Task IHarvestClient.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.MoveHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    Task IHarvestClient.RemoveHarvestWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RemoveHarvestWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    Task IHarvestClient.RemoveHarvestWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RemoveHarvestWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    Task IHarvestClient.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RenameHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    Task IHarvestClient.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RenameHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    Task IHarvestClient.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.FinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    Task IHarvestClient.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.FinishHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    Task IHarvestClient.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.UnfinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    Task IHarvestClient.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.UnfinishHarvestAsync(licenseNumber, body, cancellationToken);
}