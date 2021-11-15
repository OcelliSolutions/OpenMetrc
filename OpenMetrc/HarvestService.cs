namespace OpenMetrc;

public class HarvestService: BaseService, IHarvestClient
{
    protected HarvestService(string state, string softwareApiKey, string userApiKey, bool isSandbox, bool returnEmptyOnNotSupported = false) : base(state, softwareApiKey, userApiKey, isSandbox, returnEmptyOnNotSupported)
    {
    }

    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    public Task<Harvest> GetHarvestByIdAsync(long id, string licenseNumber)
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return Task.FromResult(new Harvest());
        return GetHarvestByIdAsync(id, licenseNumber, CancellationToken.None);
    }

    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    public Task<Harvest> GetHarvestByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken)
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return Task.FromResult(new Harvest());
        return ApiKey.HarvestClient.GetHarvestByIdAsync(id, licenseNumber, cancellationToken);
    }

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    public Task<ICollection<Harvest>> GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    public Task<ICollection<Harvest>> GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    public Task<ICollection<Harvest>> GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    public Task<ICollection<Harvest>> GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    public Task<ICollection<Harvest>> GetInactiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    public Task<ICollection<Harvest>> GetInactiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    public Task<ICollection<HarvestWasteType>> GetHarvestWasteTypesAsync() => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    public Task<ICollection<HarvestWasteType>> GetHarvestWasteTypesAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    public Task CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    public Task CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    public Task CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    public Task CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    public Task MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    public Task MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    public Task RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    public Task RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    public Task RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    public Task RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    public Task FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    public Task FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    public Task UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    public Task UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();
}
