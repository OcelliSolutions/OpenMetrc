namespace OpenMetrc;

public partial class MetrcService : IHarvest
{
    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    Task<Harvest> IHarvest.GetHarvestByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : UserMetrcClient.GetHarvestByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    Task<Harvest> IHarvest.GetHarvestByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Harvest())
            : UserMetrcClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    Task<ICollection<Harvest>> IHarvest.GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    Task<ICollection<Harvest>> IHarvest.GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetActiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    Task<ICollection<Harvest>> IHarvest.GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    Task<ICollection<Harvest>> IHarvest.GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetOnHoldHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    Task<ICollection<Harvest>> IHarvest.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    Task<ICollection<Harvest>> IHarvest.GetInactiveHarvestsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Harvest>>(new List<Harvest>())
            : UserMetrcClient.GetInactiveHarvestsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    Task<ICollection<HarvestWasteType>> IHarvest.GetHarvestWasteTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<HarvestWasteType>>(new List<HarvestWasteType>())
            : UserMetrcClient.GetHarvestWasteTypesAsync();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    Task<ICollection<HarvestWasteType>> IHarvest.GetHarvestWasteTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<HarvestWasteType>>(new List<HarvestWasteType>())
            : UserMetrcClient.GetHarvestWasteTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    Task IHarvest.CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    Task IHarvest.CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    Task IHarvest.CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageTestingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    Task IHarvest.CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePackageTestingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    Task IHarvest.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MoveHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    Task IHarvest.MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MoveHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    Task IHarvest.RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RemoveWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    Task IHarvest.RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RemoveWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    Task IHarvest.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RenameHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    Task IHarvest.RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.RenameHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    Task IHarvest.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.FinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    Task IHarvest.FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.FinishHarvestAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    Task IHarvest.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UnfinishHarvestAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    Task IHarvest.UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UnfinishHarvestAsync(licenseNumber, body, cancellationToken);
}