using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("unitsofmeasure/v2")]
[ApiVersion("2")]
[ApiController]
public class UnitOfMeasureController : ControllerBase
{
    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<UnitOfMeasure>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active units of measures")]
    public ActionResult GetActiveUnitsOfMeasure() => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<UnitOfMeasure>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive units of measures")]
    public ActionResult GetInactiveUnitsOfMeasure() => Ok();
}