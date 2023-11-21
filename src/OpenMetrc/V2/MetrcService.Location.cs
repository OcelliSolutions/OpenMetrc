namespace OpenMetrc.V2;

public partial class MetrcService : ILocationClient
{
    [MapsToApi(MetrcEndpoint.get_locations_v2_id)]
    Task<Location> ILocationClient.GetLocationByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : LocationClient.GetLocationByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v2_id)]
    Task<Location> ILocationClient.GetLocationByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : LocationClient.GetLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_locations_v2_id)]
    Task ILocationClient.DeleteLocationAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_locations_v2_id)]
    Task ILocationClient.DeleteLocationAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v2_active)]
    Task<LocationMetrcWrapper> ILocationClient.GetActiveLocationsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationMetrcWrapper())
            : LocationClient.GetActiveLocationsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v2_active)]
    Task<LocationMetrcWrapper> ILocationClient.GetActiveLocationsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationMetrcWrapper())
            : LocationClient.GetActiveLocationsAsync(licenseNumber, cancellationToken);

    Task<LocationMetrcWrapper> ILocationClient.GetInactiveLocationsAsync(string licenseNumber) => throw new NotImplementedException();

    Task<LocationMetrcWrapper> ILocationClient.GetInactiveLocationsAsync(string licenseNumber, CancellationToken cancellationToken) => throw new NotImplementedException();

    [MapsToApi(MetrcEndpoint.get_locations_v2_types)]
    Task<LocationTypeMetrcWrapper> ILocationClient.GetLocationTypesAsync(string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationTypeMetrcWrapper())
            : LocationClient.GetLocationTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v2_types)]
    Task<LocationTypeMetrcWrapper> ILocationClient.GetLocationTypesAsync(string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LocationTypeMetrcWrapper())
            : LocationClient.GetLocationTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v2)]
    Task ILocationClient.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.CreateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v2)]
    Task ILocationClient.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.CreateLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_locations_v2)]
    Task ILocationClient.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.UpdateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_locations_v2)]
    Task ILocationClient.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.UpdateLocationAsync(licenseNumber, body, cancellationToken);
}