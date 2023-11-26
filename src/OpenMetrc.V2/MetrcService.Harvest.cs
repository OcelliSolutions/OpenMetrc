namespace OpenMetrc.V2;

public partial class MetrcService : IHarvestClient
{
    [MapsToApi(MetrcEndpoint.get_harvests_v2_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_active)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetHarvestActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetHarvestActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_onhold)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetHarvestOnHoldAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetHarvestOnHoldAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_inactive)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetHarvestInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetHarvestInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste)]
    Task<HarvestWasteMetrcWrapper> IHarvestClient.GetHarvestWasteAsync(string licenseNumber, long harvestId, int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestWasteMetrcWrapper())
            : HarvestClient.GetHarvestWasteAsync(licenseNumber, harvestId, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste_types)]
    Task<HarvestWasteTypeMetrcWrapper> IHarvestClient.GetHarvestWasteTypesAsync(int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestWasteTypeMetrcWrapper())
            : HarvestClient.GetHarvestWasteTypesAsync(pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages)]
    Task IHarvestClient.PostHarvestPackagesAsync(string licenseNumber, IEnumerable<PostHarvestPackagesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestPackagesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages_testing)]
    Task IHarvestClient.PostHarvestPackageTestingAsync(string licenseNumber,
        IEnumerable<PostHarvestPackageTestingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestPackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_location)]
    Task IHarvestClient.PutHarvestLocationAsync(string licenseNumber, IEnumerable<PutHarvestLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_waste)]
    Task IHarvestClient.PostHarvestWasteAsync(string licenseNumber, IEnumerable<PostHarvestWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PostHarvestWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_rename)]
    Task IHarvestClient.PutHarvestRenameAsync(string licenseNumber, IEnumerable<PutHarvestRenameRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestRenameAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_finish)]
    Task IHarvestClient.PutHarvestFinishAsync(string licenseNumber, IEnumerable<PutHarvestFinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestFinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_unfinish)]
    Task IHarvestClient.PutHarvestUnfinishAsync(string licenseNumber, IEnumerable<PutHarvestUnfinishRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestUnfinishAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_restore_harvestedplants)]
    Task IHarvestClient.PutHarvestRestoreHarvestedPlantsAsync(string licenseNumber, IEnumerable<PutHarvestRestoreHarvestedPlantsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.PutHarvestRestoreHarvestedPlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_harvests_v2_waste_id)]
    Task IHarvestClient.DeleteHarvestWasteByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.DeleteHarvestWasteByIdAsync(id, licenseNumber, cancellationToken);
}