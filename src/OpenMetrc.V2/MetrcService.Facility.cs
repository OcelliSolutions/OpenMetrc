namespace OpenMetrc.V2;

public partial class MetrcService : IFacilityClient
{
    [MapsToApi(MetrcEndpoint.get_facilities_v2)]
    Task<ICollection<Facility>?> IFacilityClient.GetFacilitiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Facility>?>(new List<Facility>())
            : FacilityClient.GetFacilitiesAsync();

    [MapsToApi(MetrcEndpoint.get_facilities_v2)]
    Task<ICollection<Facility>?> IFacilityClient.GetFacilitiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Facility>?>(new List<Facility>())
            : FacilityClient.GetFacilitiesAsync(cancellationToken);
}