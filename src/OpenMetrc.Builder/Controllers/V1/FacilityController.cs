using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V1;

[Route("facilities/v1")]
[ApiVersion("1")]
[ApiController]
public class FacilityController : FacilitiesControllerBase
{
    // <inheritDoc />
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_facilities_v1)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<Facility>), StatusCodes.Status200OK)]
    public override Task GetFacilities() => throw new NotImplementedException();
}