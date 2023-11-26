namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class LocationController : LocationsControllerBase
{
    /// <inheritdoc cref="LocationsControllerBase.GetLocationById" />
    [MapsToApi(MetrcEndpoint.get_locations_v2_id)]
    [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
    public override Task GetLocationById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.GetLocationActive" />
    [MapsToApi(MetrcEndpoint.get_locations_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Location>), StatusCodes.Status200OK)]
    public override Task GetLocationActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.GetLocationInactive" />
    [MapsToApi(MetrcEndpoint.get_locations_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Location>), StatusCodes.Status200OK)]
    public override Task GetLocationInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.GetLocationTypes" />
    [MapsToApi(MetrcEndpoint.get_locations_v2_types)]
    [ProducesResponseType(typeof(MetrcWrapper<LocationType>), StatusCodes.Status200OK)]
    public override Task GetLocationTypes(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.PostLocations" />
    [MapsToApi(MetrcEndpoint.post_locations_v2)]
    public override Task PostLocations(
        [Required] List<PostLocationsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.PutLocations" />
    [MapsToApi(MetrcEndpoint.put_locations_v2)]
    public override Task PutLocations(
        [Required] List<PutLocationsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.DeleteLocationById" />
    [MapsToApi(MetrcEndpoint.delete_locations_v2_id)]
    public override Task DeleteLocationById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}