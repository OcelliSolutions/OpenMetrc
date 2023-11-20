using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("facilities/v1")]
[ApiVersion("1")]
[ApiController]
public class FacilityController : ControllerBase
{
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_facilities_v1)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<Facility>), StatusCodes.Status200OK)]
    [SwaggerOperation(
        Summary = "A Facility represents a building licensed for the growing, processing, and/or selling of product",
        Description = "This endpoint provides a list of facilities for which the authenticated user has access.")]
    public ActionResult GetFacilities() => Ok();
}