namespace OpenMetrc.V1;

public partial class MetrcService : IHarvestClient
{
    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    Task<ICollection<Harvest>?> IHarvestClient.GetHarvestActiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>?>(new List<Harvest>())
            : HarvestClient.GetHarvestActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    Task<ICollection<Harvest>?> IHarvestClient.GetHarvestOnHoldAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>?>(new List<Harvest>())
            : HarvestClient.GetHarvestOnHoldAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    Task<ICollection<Harvest>?> IHarvestClient.GetHarvestInactiveAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>?>(new List<Harvest>())
            : HarvestClient.GetHarvestInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    Task<ICollection<HarvestWasteType>?> IHarvestClient.
        GetHarvestWasteTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<HarvestWasteType>?>(new List<HarvestWasteType>())
            : HarvestClient.GetHarvestWasteTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    Task IHarvestClient.PostHarvestCreatePackagesAsync(string licenseNumber, IEnumerable<PostHarvestCreatePackagesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestCreatePackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    Task IHarvestClient.PostHarvestCreatePackageTestingAsync(string licenseNumber,
        IEnumerable<PostHarvestCreatePackageTestingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestCreatePackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    Task IHarvestClient.PutHarvestMoveAsync(string licenseNumber, IEnumerable<PutHarvestMoveRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestMoveAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    Task IHarvestClient.PostHarvestRemoveWasteAsync(string licenseNumber, IEnumerable<PostHarvestRemoveWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestRemoveWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    Task IHarvestClient.PutHarvestRenameAsync(string licenseNumber, IEnumerable<PutHarvestRenameRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestRenameAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    Task IHarvestClient.PostHarvestFinishAsync(string licenseNumber, IEnumerable<PostHarvestFinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    Task IHarvestClient.PostHarvestUnfinishAsync(string licenseNumber, IEnumerable<PostHarvestUnfinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestUnfinishAsync(licenseNumber, body, cancellationToken);
}