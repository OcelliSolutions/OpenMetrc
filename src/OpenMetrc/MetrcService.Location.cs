namespace OpenMetrc;

public partial class MetrcService : ILocationClient
{
    [MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    Task<Location> ILocationClient.GetLocationByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : LocationClient.GetLocationByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    Task<Location> ILocationClient.GetLocationByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : LocationClient.GetLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    Task ILocationClient.DeleteLocationAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    Task ILocationClient.DeleteLocationAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>> ILocationClient.GetActiveLocationsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>>(new List<Location>())
            : LocationClient.GetActiveLocationsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>> ILocationClient.GetActiveLocationsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>>(new List<Location>())
            : LocationClient.GetActiveLocationsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>> ILocationClient.GetLocationTypesAsync(string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>>(new List<LocationType>())
            : LocationClient.GetLocationTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>> ILocationClient.GetLocationTypesAsync(string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>>(new List<LocationType>())
            : LocationClient.GetLocationTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocationClient.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.CreateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocationClient.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.CreateLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocationClient.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.UpdateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocationClient.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest>? body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.UpdateLocationAsync(licenseNumber, body, cancellationToken);
}