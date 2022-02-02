namespace OpenMetrc.Builder.Controllers.V1;

[Route("packages/v1")]
[ApiController]
public class PackageController : ControllerBase
{
    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific package by id")]
    public ActionResult GetPackageById(
        [Required] [SwaggerParameter(Description = "Package ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Package will be validated against the specified License Number. If not specified, the Package will be validated against all of the User's current Facilities. Please note that if the Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("{label}")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific package by label")]
    public ActionResult GetPackageByLabel(
        [Required] [SwaggerParameter(Description = "Package Label")]
        string label,
        [SwaggerParameter(Description =
            "If specified, the Package will be validated against the specified License Number. If not specified, the Package will be validated against all of the User's current Facilities. Please note that if the Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get packages in an active status")]
    public ActionResult GetActivePackages(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active packages.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("onhold")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get packages in an onhold status")]
    public ActionResult GetOnHoldPackages(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of onhold packages.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get packages in an inactive status")]
    public ActionResult GetInactivePackages(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive packages.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get package types")]
    public ActionResult GetPackageTypes() => Ok();

    [HttpGet("adjust/reasons")]
    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<PackageAdjustReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get package adjust reasons")]
    public ActionResult GetPackageAdjustReasons(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive packages.")]
        string licenseNumber) => Ok();

    [HttpPost("create")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Create packages")]
    public ActionResult CreatePackage([Required] string licenseNumber,
        List<CreatePackageRequest> createPackageRequests) => Ok();

    [HttpPost("create/testing")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Create testing packages")]
    public ActionResult CreateTestingPackage([Required] string licenseNumber,
        List<CreatePackageRequest> createPackageRequests) => Ok();

    [HttpPost("create/plantings")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlants, ApiPermission.ViewPackages,
        ApiPermission.ManagePackagesInventory
    })]
    [SwaggerOperation(Summary = "Create package plantings")]
    public ActionResult CreatePackagePlanting([Required] string licenseNumber,
        List<CreatePackagePlantingRequest> createPackagePlantingRequests) => Ok();

    [HttpPost("change/item")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Change the package item")]
    public ActionResult ChangePackageItem([Required] string licenseNumber,
        List<ChangePackageItemRequest> changePackageItemRequests) => Ok();

    [HttpPut("change/note")]
    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
        { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory, ApiPermission.ManagePackageNotes })]
    [SwaggerOperation(Summary = "Update a package note")]
    public ActionResult ChangePackageNote([Required] string licenseNumber,
        List<ChangePackageNoteRequest> changePackageNoteRequests) => Ok();

    [HttpPost("change/locations")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Change a package location")]
    public ActionResult ChangePackageLocation([Required] string licenseNumber,
        List<ChangePackageLocationRequest> changePackageLocationRequests) => Ok();

    [HttpPost("adjust")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Adjust packages")]
    public ActionResult AdjustPackage([Required] string licenseNumber,
        List<AdjustPackageRequest> adjustPackageRequests) => Ok();

    [HttpPost("finish")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Finish packages")]
    public ActionResult FinishPackage([Required] string licenseNumber,
        List<FinishPackageRequest> finishPackageRequests) => Ok();

    [HttpPost("unfinish")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Unfinish packages")]
    public ActionResult UnfinishPackage([Required] string licenseNumber,
        List<UnfinishPackageRequest> unfinishPackageRequests) => Ok();

    [HttpPost("remediate")]
    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Remediate packages")]
    public ActionResult RemediatePackage([Required] string licenseNumber,
        List<RemediatePackageRequest> remediatePackageRequests) => Ok();
}