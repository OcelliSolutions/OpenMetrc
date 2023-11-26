namespace OpenMetrc.V2;

public partial class MetrcService : ILocationClient
{
    [MapsToApi(MetrcEndpoint.get_locations_v2_id)]
    Task<Location> ILocationClient.GetLocationByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : LocationClient.GetLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_locations_v2_id)]
    Task ILocationClient.DeleteLocationByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v2_active)]
    Task<LocationMetrcWrapper> ILocationClient.GetLocationActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationMetrcWrapper())
            : LocationClient.GetLocationActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v2_inactive)]
    Task<LocationMetrcWrapper> ILocationClient.GetLocationInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationMetrcWrapper())
            : LocationClient.GetLocationInactiveAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v2_types)]
    Task<LocationTypeMetrcWrapper> ILocationClient.GetLocationTypesAsync(string licenseNumber,
        int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationTypeMetrcWrapper())
            : LocationClient.GetLocationTypesAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v2)]
    Task ILocationClient.PostLocationsAsync(string licenseNumber, IEnumerable<PostLocationsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PostLocationsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_locations_v2)]
    Task ILocationClient.PutLocationsAsync(string licenseNumber, IEnumerable<PutLocationsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PutLocationsAsync(licenseNumber, body, cancellationToken);
}