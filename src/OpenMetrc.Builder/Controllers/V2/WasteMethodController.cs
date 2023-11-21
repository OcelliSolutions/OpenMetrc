using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("wastemethods/v2")]
[ApiVersion("2")]
[ApiController]
public class WasteMethodController : ControllerBase
{
    [HttpGet]
    [MapsToApi(MetrcEndpoint.get_wastemethods_v2)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(ICollection<WasteMethod>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Returns a list of waste methods.")]
    public ActionResult GetWasteMethods() => Ok();
}