namespace OpenMetrc.V1;

public partial class MetrcService : IFacilityClient
{
    [MapsToApi(MetrcEndpoint.get_facilities_v1)]
    Task<ICollection<Facility>?> IFacilityClient.GetFacilitiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Facility>?>(new List<Facility>())
            : FacilityClient.GetFacilitiesAsync(cancellationToken);
}