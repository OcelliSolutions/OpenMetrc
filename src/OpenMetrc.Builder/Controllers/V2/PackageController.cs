using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("packages/v2")]
[ApiVersion("2")]
[ApiController]
public class PackageController : ControllerBase
{
    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_id)]
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

    [HttpGet("{id}/source/harvests")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_id_source_harvests)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackageSourceHarvests })]
    [ProducesResponseType(typeof(PackageSourceHarvest), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a package's source harvests")]
    public ActionResult GetPackageSourceHarvests(
        [Required] [SwaggerParameter(Description = "Package ID")]
        long id,
        [Required] string licenseNumber
    ) => Ok();

    [HttpGet("{label}")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_label)]
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
    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
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

    [HttpGet("intransit")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_intransit)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get packages in an intransit status")]
    public ActionResult GetIntransitPackages(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive packages.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("labsamples")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_labsamples)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<PackageLabTest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get packages in an intransit status")]
    public ActionResult GetPackageLabTests(
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
    [MapsToApi(MetrcEndpoint.get_packages_v2_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get package types")]
    public ActionResult GetPackageTypes() => Ok();

    [HttpGet("adjust/reasons")]
    [MapsToApi(MetrcEndpoint.get_packages_v2_adjust_reasons)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<PackageAdjustReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get package adjust reasons")]
    public ActionResult GetPackageAdjustReasons(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive packages.")]
        string licenseNumber) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Create packages")]
    public ActionResult CreatePackage([Required] string licenseNumber,
        [Required] List<CreatePackageRequest> createPackageRequests) => Ok();

    [HttpPost("testing")]
    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Create testing packages")]
    public ActionResult CreateTestingPackage([Required] string licenseNumber,
        [Required] List<CreatePackageRequest> createPackageRequests) => Ok();

    [HttpPost("plantings")]
    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlants, ApiPermission.ViewPackages,
        ApiPermission.ManagePackagesInventory
    })]
    [SwaggerOperation(Summary = "Create package plantings")]
    public ActionResult CreatePackagePlanting([Required] string licenseNumber,
        [Required] List<CreatePackagePlantingRequest> createPackagePlantingRequests) => Ok();

    [HttpPost("donation/flag")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_flag)]
    [Authorize]
    [ApiAuthorizationFilter(new[]{ ApiPermission.ViewPackages,ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Flag package for donation")]
    public ActionResult FlagPackageForDonation([Required] string licenseNumber,
        [Required] List<PackageDonationRequest> packageDonationRequest) => Ok();

    [HttpPost("donation/unflag")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_unflag)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Unflag package for donation")]
    public ActionResult UnflagPackageForDonation([Required] string licenseNumber,
        [Required] List<PackageDonationRequest> packageDonationRequest) => Ok();

    [HttpPut("item")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Change the package item")]
    public ActionResult ChangePackageItem([Required] string licenseNumber,
        [Required] List<ChangePackageItemRequest> changePackageItemRequests) => Ok();

    [HttpPut("note")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
        { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory, ApiPermission.ManagePackageNotes })]
    [SwaggerOperation(Summary = "Update a package note")]
    public ActionResult ChangePackageNote([Required] string licenseNumber,
        [Required] List<ChangePackageNoteRequest> changePackageNoteRequests) => Ok();

    [HttpPut("location")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Change a package location")]
    public ActionResult ChangePackageLocation([Required] string licenseNumber,
        [Required] List<ChangePackageLocationRequest> changePackageLocationRequests) => Ok();

    [HttpPut("labtests/required")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_labtests_required)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Update packages to require lab tests")]
    public ActionResult PackageLabTestsRequired([Required] string licenseNumber,
        [Required] List<PackageLabTestsRequiredRequest> packageLabTestsRequiredRequests) => Ok();

    [HttpPut("tradesample/flag")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_flag)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Flag a packages as a trade sample")]
    public ActionResult FlagPackageTradeSample([Required] string licenseNumber,
        [Required] List<PackageTradeSampleRequest> packageTradeSampleRequests) => Ok();

    [HttpPut("tradesample/unflag")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_unflag)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Unflag a packages as a trade sample")]
    public ActionResult UnflagPackageTradeSample([Required] string licenseNumber,
        [Required] List<PackageTradeSampleRequest> packageTradeSampleRequests) => Ok();

    [HttpPost("adjust")]
    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Adjust packages")]
    public ActionResult AdjustPackage([Required] string licenseNumber,
        [Required] List<AdjustPackageRequest> adjustPackageRequests) => Ok();

    [HttpPut("remediate")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Remediate packages")]
    public ActionResult RemediatePackage([Required] string licenseNumber,
        [Required] List<RemediatePackageRequest> remediatePackageRequests) => Ok();

    [HttpPut("finish")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Finish packages")]
    public ActionResult FinishPackage([Required] string licenseNumber,
        [Required] List<FinishPackageRequest> finishPackageRequests) => Ok();

    [HttpPut("unfinish")]
    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Unfinish packages")]
    public ActionResult UnfinishPackage([Required] string licenseNumber,
        [Required] List<UnfinishPackageRequest> unfinishPackageRequests) => Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_packages_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.CreateSubmitDiscontinuePackages })]
    [SwaggerOperation(Summary = "Delete packages")]
    public ActionResult DeletePackage(
        [Required] long id,
        [Required] string licenseNumber) => Ok();
}