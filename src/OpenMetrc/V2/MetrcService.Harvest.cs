namespace OpenMetrc.V2;

public partial class MetrcService : IHarvestClient
{
    [MapsToApi(MetrcEndpoint.get_harvests_v2_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_id)]
    Task<Harvest> IHarvestClient.GetHarvestByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : HarvestClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_active)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetActiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_active)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetActiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_onhold)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetOnHoldHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_onhold)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetOnHoldHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_inactive)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v2_inactive)]
    Task<HarvestMetrcWrapper> IHarvestClient.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestMetrcWrapper())
            : HarvestClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    Task<HarvestWasteMetrcWrapper> IHarvestClient.GetHarvestWasteAsync() => throw new NotImplementedException();

    Task<HarvestWasteMetrcWrapper> IHarvestClient.GetHarvestWasteAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste_types)]
    Task<HarvestWasteTypeMetrcWrapper> IHarvestClient.GetHarvestWasteTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestWasteTypeMetrcWrapper())
            : HarvestClient.GetHarvestWasteTypesAsync();

    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste_types)]
    Task<HarvestWasteTypeMetrcWrapper> IHarvestClient.
        GetHarvestWasteTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new HarvestWasteTypeMetrcWrapper())
            : HarvestClient.GetHarvestWasteTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages)]
    Task IHarvestClient.
        CreateHarvestPackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages)]
    Task IHarvestClient.CreateHarvestPackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages_testing)]
    Task IHarvestClient.CreateHarvestPackageTestingAsync(string licenseNumber,
        IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageTestingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages_testing)]
    Task IHarvestClient.CreateHarvestPackageTestingAsync(string licenseNumber,
        IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.CreateHarvestPackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_location)]
    Task IHarvestClient.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.MoveHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_location)]
    Task IHarvestClient.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.MoveHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_waste)]
    Task IHarvestClient.RemoveHarvestWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RemoveHarvestWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v2_waste)]
    Task IHarvestClient.RemoveHarvestWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RemoveHarvestWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_rename)]
    Task IHarvestClient.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RenameHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_rename)]
    Task IHarvestClient.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.RenameHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_finish)]
    Task IHarvestClient.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.FinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_finish)]
    Task IHarvestClient.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.FinishHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_unfinish)]
    Task IHarvestClient.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.UnfinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v2_unfinish)]
    Task IHarvestClient.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : HarvestClient.UnfinishHarvestAsync(licenseNumber, body, cancellationToken);

    Task IHarvestClient.RestoreHarvestedPlantsAsync(string licenseNumber, IEnumerable<RestoreHarvestedPlantsRequest> body) => throw new NotImplementedException();

    Task IHarvestClient.RestoreHarvestedPlantsAsync(string licenseNumber, IEnumerable<RestoreHarvestedPlantsRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task IHarvestClient.DeleteWasteAsync(long id) => throw new NotImplementedException();

    Task IHarvestClient.DeleteWasteAsync(long id, CancellationToken cancellationToken) => throw new NotImplementedException();
}