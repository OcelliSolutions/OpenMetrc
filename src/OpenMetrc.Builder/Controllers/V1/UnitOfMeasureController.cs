namespace OpenMetrc.Builder.Controllers.V1;

[Route("unitsofmeasure/v1")]
[ApiController]
public class UnitOfMeasureController : ControllerBase
{
    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<UnitOfMeasure>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all units of measures")]
    public ActionResult GetUnitsOfMeasure() => Ok();
}