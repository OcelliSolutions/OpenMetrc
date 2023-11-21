using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("strains/v2")]
[ApiVersion("2")]
[ApiController]
public class StrainController : ControllerBase
{
    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_strains_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [ProducesResponseType(typeof(Strain), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific strain by id")]
    public ActionResult GetStrainById(
        [Required] [SwaggerParameter(Description = "Strain ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Strain will be validated against the specified License Number. If not specified, the Strain will be validated against all of the User's current Facilities. Please note that if the Strain is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_strains_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [ProducesResponseType(typeof(MetrcWrapper<Strain>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active strains")]
    public ActionResult GetActiveStrains(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active strains.")]
        string licenseNumber) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_strains_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [ProducesResponseType(typeof(MetrcWrapper<Strain>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive strains")]
    public ActionResult GetInactiveStrains(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive strains.")]
        string licenseNumber) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_strains_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Create strains")]
    public ActionResult CreateStrain([Required] string licenseNumber,
        [Required] List<CreateStrainRequest> createStrainRequests) =>
        Ok();

    [HttpPut()]
    [MapsToApi(MetrcEndpoint.put_strains_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Update strains")]
    public ActionResult UpdateStrain([Required] string licenseNumber,
        [Required] List<UpdateStrainRequest> updateStrainRequests) =>
        Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_strains_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Delete an strain")]
    public ActionResult DeleteStrain([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Strain ID")]
        long id) => Ok();
}