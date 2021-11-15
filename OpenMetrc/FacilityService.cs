namespace OpenMetrc;

public class FacilityService : BaseService, IFacilityClient
{
    protected FacilityService(string state, string softwareApiKey, string userApiKey, bool isSandbox, bool returnEmptyOnNotSupported = false) : base(state, softwareApiKey, userApiKey, isSandbox, returnEmptyOnNotSupported)
    {
    }

    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    public Task<ICollection<Facility>> GetFacilitiesAsync()
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return Task.FromResult<ICollection<Facility>>(new List<Facility>());
        return GetFacilitiesAsync(CancellationToken.None);
    }

    public async Task<ICollection<Facility>> GetFacilitiesAsync(CancellationToken cancellationToken)
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return new List<Facility>();
        return await ApiKey.FacilityClient.GetFacilitiesAsync(cancellationToken);
    }
}