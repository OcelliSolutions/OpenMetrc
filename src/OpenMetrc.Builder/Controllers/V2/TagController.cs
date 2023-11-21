using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("tags/v2")]
[ApiVersion("2")]
[ApiController]
public class TagController : ControllerBase
{
    [HttpGet("plant/available")]
    [MapsToApi(MetrcEndpoint.get_tags_v2_plant_available)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(ICollection<Tag>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Returns a list of available Plant Tags. NOTE: This is a premium endpoint.")]
    public ActionResult GetAvailablePlantTags(
        [Required, SwaggerParameter(Description = "The license number for which to return available tags.")] string licenseNumber
        ) => Ok();

    [HttpGet("package/available")]
    [MapsToApi(MetrcEndpoint.get_tags_v2_package_available)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(ICollection<Tag>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Returns a list of available Package Tags. NOTE: This is a premium endpoint.")]
    public ActionResult GetAvailablePackageTags(
        [Required, SwaggerParameter(Description = "The license number for which to return available package tags.")] string licenseNumber
    ) => Ok();
}