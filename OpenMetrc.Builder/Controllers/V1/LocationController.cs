namespace OpenMetrc.Builder.Controllers.V1;

[Route("locations/v1")]
[ApiController]
public class LocationController : ControllerBase
{
    [HttpGet("{id:long}"), MapsToApi(MetrcEndpoint.get_locations_v1_id)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific location by id")]
    public ActionResult GetLocationById(
        [Required, SwaggerParameter(Description = "Location ID")] long id,
        [SwaggerParameter(Description = "If specified, the Location will be validated against the specified License Number. If not specified, the Location will be validated against all of the User's current Facilities. Please note that if the Location is not valid for the specified License Number, a 401 Unauthorized status will be returned.")] string licenseNumber
        ) => Ok();

    [HttpGet("active"), MapsToApi(MetrcEndpoint.get_locations_v1_active)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(IEnumerable<Location>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active locations")]
    public ActionResult GetActiveLocations(
        [Required, SwaggerParameter(Description = "The license number of the facility for which to return the list of active locations.")] string licenseNumber
        ) => Ok();

    [HttpGet("types"), MapsToApi(MetrcEndpoint.get_locations_v1_types)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(IEnumerable<LocationType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get location types")]
    public ActionResult GetLocationTypes(
        [SwaggerParameter(Description = "The license number of the facility for which to return the list of active location types.")] string licenseNumber
        ) => Ok();

    [HttpPost("create"), MapsToApi(MetrcEndpoint.post_locations_v1_create)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Create locations")]
    public ActionResult CreateLocation([Required] string licenseNumber, List<CreateLocationRequest> createLocationRequests) => Ok();

    [HttpPost("update"), MapsToApi(MetrcEndpoint.post_locations_v1_update)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Update locations")]
    public ActionResult UpdateLocation([Required] string licenseNumber, List<UpdateLocationRequest> updateLocationRequests) => Ok();

    [HttpDelete("{id:long}"), MapsToApi(MetrcEndpoint.delete_locations_v1_id)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Delete an location")]
    public ActionResult DeleteLocation([Required] string licenseNumber, [Required, SwaggerParameter(Description = "Location ID")] long id) => Ok();
}
