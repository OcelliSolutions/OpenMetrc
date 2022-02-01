namespace OpenMetrc.Builder.Controllers.V1;

[Route("strains/v1")]
[ApiController]
public class StrainController : ControllerBase
{
    [HttpGet("{id:long}"), MapsToApi(MetrcEndpoint.get_strains_v1_id)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [ProducesResponseType(typeof(Strain), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific strain by id")]
    public ActionResult GetStrainById(
        [Required, SwaggerParameter(Description = "Strain ID")] long id,
        [SwaggerParameter(Description = "If specified, the Strain will be validated against the specified License Number. If not specified, the Strain will be validated against all of the User's current Facilities. Please note that if the Strain is not valid for the specified License Number, a 401 Unauthorized status will be returned.")] string licenseNumber
        ) => Ok();

    [HttpGet("active"), MapsToApi(MetrcEndpoint.get_strains_v1_active)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [ProducesResponseType(typeof(IEnumerable<Strain>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active strains")]
    public ActionResult GetActiveStrains([Required, SwaggerParameter(Description = "The license number of the facility for which to return the list of active strains.")] string licenseNumber) => Ok();

    [HttpPost("create"), MapsToApi(MetrcEndpoint.post_strains_v1_create)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Create strains")]
    public ActionResult CreateStrain([Required] string licenseNumber, List<CreateStrainRequest> createStrainRequests) => Ok();

    [HttpPost("update"), MapsToApi(MetrcEndpoint.post_strains_v1_update)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Update strains")]
    public ActionResult UpdateStrain([Required] string licenseNumber, List<UpdateStrainRequest> updateStrainRequests) => Ok();

    [HttpDelete("{id:long}"), MapsToApi(MetrcEndpoint.delete_strains_v1_id)]
    [Authorize, ApiAuthorizationFilter(new[] { ApiPermission.ManageStrains })]
    [SwaggerOperation(Summary = "Delete an strain")]
    public ActionResult DeleteStrain([Required] string licenseNumber, [Required, SwaggerParameter(Description = "Strain ID")] long id) => Ok();
}
