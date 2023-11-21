namespace OpenMetrc.V2;

public partial class MetrcService : IFacilityClient
{
    [MapsToApi(MetrcEndpoint.get_facilities_v2)]
    Task<FacilityMetrcWrapper> IFacilityClient.GetFacilitiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new FacilityMetrcWrapper())
            : FacilityClient.GetFacilitiesAsync();

    [MapsToApi(MetrcEndpoint.get_facilities_v2)]
    Task<FacilityMetrcWrapper> IFacilityClient.GetFacilitiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new FacilityMetrcWrapper())
            : FacilityClient.GetFacilitiesAsync(cancellationToken);
}