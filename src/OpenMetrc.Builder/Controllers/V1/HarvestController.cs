namespace OpenMetrc.Builder.Controllers.V1;

[Route("harvests/v1")]
[ApiController]
public class HarvestController : ControllerBase
{
    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests })]
    [ProducesResponseType(typeof(Harvest), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific harvest by id")]
    public ActionResult GetHarvestById(
        [Required] [SwaggerParameter(Description = "Harvest ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Harvest will be validated against the specified License Number. If not specified, the Harvest will be validated against all of the User's current Facilities. Please note that if the Harvest is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests })]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get harvests in an active status")]
    public ActionResult GetActiveHarvests(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active harvests.  License <code>CanGrowPlants</code>")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("onhold")]
    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests })]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get harvests in an onhold status")]
    public ActionResult GetOnHoldHarvests(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of onhold harvests.  License <code>CanGrowPlants</code>")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests })]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get harvests in an inactive status")]
    public ActionResult GetInactiveHarvests(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive harvests.  License <code>CanGrowPlants</code>")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("waste/types")]
    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<HarvestWasteType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get harvests waste types")]
    public ActionResult GetHarvestWasteTypes() => Ok();

    [HttpPost("create/packages")]
    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewHarvests, ApiPermission.ManageHarvests, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create packages for one or more harvests")]
    public ActionResult CreateHarvestPackage([Required] string licenseNumber,
        [Required] List<CreateHarvestPackageRequest> createHarvestPackageRequests) => Ok();

    [HttpPost("create/packages/testing")]
    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewHarvests, ApiPermission.ManageHarvests, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create packages for one or more harvests for testing")]
    public ActionResult CreateHarvestPackageTesting([Required] string licenseNumber,
        [Required] List<CreateHarvestPackageRequest> createHarvestPackageRequests) => Ok();

    [HttpPut("move")]
    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests, ApiPermission.ManageHarvests })]
    [SwaggerOperation(Summary = "Move a harvest to a new room")]
    public ActionResult MoveHarvest([Required] string licenseNumber, List<MoveHarvestRequest> moveHarvestRequests) =>
        Ok();

    [HttpPost("removewaste")]
    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests, ApiPermission.ManageHarvests })]
    [SwaggerOperation(Summary = "Remove waste from a harvest")]
    public ActionResult RemoveHarvestWaste([Required] string licenseNumber,
        List<RemoveWasteRequest> removeWasteRequests) =>
        Ok();

    [HttpPut("rename")]
    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests, ApiPermission.ManageHarvests })]
    [SwaggerOperation(Summary = "Rename a harvest")]
    public ActionResult RenameHarvest([Required] string licenseNumber,
        List<RenameHarvestRequest> renameHarvestRequests) => Ok();

    [HttpPost("finish")]
    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests, ApiPermission.FinishDiscontinueHarvests })]
    [SwaggerOperation(Summary = "Finish a harvest")]
    public ActionResult FinishHarvest([Required] string licenseNumber,
        List<FinishHarvestRequest> finishHarvestRequests) => Ok();

    [HttpPost("unfinish")]
    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewHarvests, ApiPermission.FinishDiscontinueHarvests })]
    [SwaggerOperation(Summary = "Unfinish a harvest")]
    public ActionResult UnfinishHarvest([Required] string licenseNumber,
        List<UnfinishHarvestRequest> unfinishHarvestRequests) => Ok();
}