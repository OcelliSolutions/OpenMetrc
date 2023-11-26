namespace OpenMetrc.V1;

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
    Task ILocationClient.DeleteLocationByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    Task ILocationClient.DeleteLocationByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.DeleteLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>?> ILocationClient.GetLocationActiveAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>?>(new List<Location>())
            : LocationClient.GetLocationActiveAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>?> ILocationClient.GetLocationActiveAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>?>(new List<Location>())
            : LocationClient.GetLocationActiveAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>?> ILocationClient.GetLocationTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>?>(new List<LocationType>())
            : LocationClient.GetLocationTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>?> ILocationClient.GetLocationTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>?>(new List<LocationType>())
            : LocationClient.GetLocationTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocationClient.PostLocationCreateAsync(string licenseNumber, IEnumerable<PostLocationCreateRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PostLocationCreateAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocationClient.PostLocationCreateAsync(string licenseNumber, IEnumerable<PostLocationCreateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PostLocationCreateAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocationClient.PostLocationUpdateAsync(string licenseNumber, IEnumerable<PostLocationUpdateRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PostLocationUpdateAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocationClient.PostLocationUpdateAsync(string licenseNumber, IEnumerable<PostLocationUpdateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LocationClient.PostLocationUpdateAsync(licenseNumber, body, cancellationToken);
}