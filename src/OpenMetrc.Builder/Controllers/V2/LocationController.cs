using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("locations/v2")]
[ApiVersion("2")]
[ApiController]
public class LocationController : ControllerBase
{
    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_locations_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific location by id")]
    public ActionResult GetLocationById(
        [Required] [SwaggerParameter(Description = "Location ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Location will be validated against the specified License Number. If not specified, the Location will be validated against all of the User's current Facilities. Please note that if the Location is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_locations_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(MetrcWrapper<Location>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active locations")]
    public ActionResult GetActiveLocations(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active locations.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_locations_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(MetrcWrapper<Location>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active locations")]
    public ActionResult GetInactiveLocations(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active locations.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_locations_v2_types)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [ProducesResponseType(typeof(MetrcWrapper<LocationType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get location types")]
    public ActionResult GetLocationTypes(
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active location types.")]
        string licenseNumber
    ) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_locations_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Create locations")]
    public ActionResult CreateLocation([Required] string licenseNumber,
        [Required] List<CreateLocationRequest> createLocationRequests) => Ok();

    [HttpPut]
    [MapsToApi(MetrcEndpoint.put_locations_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Update locations")]
    public ActionResult UpdateLocation([Required] string licenseNumber,
        [Required] List<UpdateLocationRequest> updateLocationRequests) => Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_locations_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageLocations })]
    [SwaggerOperation(Summary = "Delete an location")]
    public ActionResult DeleteLocation([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Location ID")]
        long id) => Ok();
}