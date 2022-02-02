namespace OpenMetrc;

public partial class MetrcService : ILocation
{
    [MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    Task<Location> ILocation.GetLocationByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : MetrcClient.GetLocationByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    Task<Location> ILocation.GetLocationByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Location())
            : MetrcClient.GetLocationByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    Task ILocation.DeleteLocationAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteLocationAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    Task ILocation.DeleteLocationAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteLocationAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>> ILocation.GetActiveLocationsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>>(new List<Location>())
            : MetrcClient.GetActiveLocationsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    Task<ICollection<Location>> ILocation.GetActiveLocationsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Location>>(new List<Location>())
            : MetrcClient.GetActiveLocationsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>> ILocation.GetLocationTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>>(new List<LocationType>())
            : MetrcClient.GetLocationTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    Task<ICollection<LocationType>> ILocation.GetLocationTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<LocationType>>(new List<LocationType>())
            : MetrcClient.GetLocationTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocation.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    Task ILocation.CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocation.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    Task ILocation.UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateLocationAsync(licenseNumber, body, cancellationToken);
}