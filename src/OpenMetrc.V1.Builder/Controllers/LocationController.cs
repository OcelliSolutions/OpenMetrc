namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class LocationController : LocationsControllerBase
{
    /// <inheritdoc cref="LocationsControllerBase.GetLocationById" />
    [MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
    public override Task GetLocationById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.GetLocationActive" />
    [MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Location>), StatusCodes.Status200OK)]
    public override Task GetLocationActive(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.GetLocationTypes" />
    [MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    [ProducesResponseType(typeof(IEnumerable<LocationType>), StatusCodes.Status200OK)]
    public override Task GetLocationTypes(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.PostLocationCreate" />
    [MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    public override Task PostLocationCreate(
        [Required] List<PostLocationCreateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.PostLocationUpdate" />
    [MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    public override Task PostLocationUpdate(
        [Required] List<PostLocationUpdateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LocationsControllerBase.DeleteLocationById" />
    [MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    public override Task DeleteLocationById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}