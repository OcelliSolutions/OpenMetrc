namespace OpenMetrc;

public partial class MetrcService : IFacility
{
    [MapsToApi(MetrcEndpoint.get_facilities_v1_)]
    Task<ICollection<Facility>> IFacility.GetFacilitiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Facility>>(new List<Facility>())
            : MetrcClient.GetFacilitiesAsync();

    [MapsToApi(MetrcEndpoint.get_facilities_v1_)]
    Task<ICollection<Facility>> IFacility.GetFacilitiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Facility>>(new List<Facility>())
            : MetrcClient.GetFacilitiesAsync(cancellationToken);
}