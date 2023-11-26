namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PackageController : PackagesControllerBase
{
    /// <inheritdoc cref="PackagesControllerBase.DeletePackageById" />
    [MapsToApi(MetrcEndpoint.delete_packages_v2_id)]
    public override Task DeletePackageById([Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageById" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_id)]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    public override Task GetPackageById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageIntransit" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_intransit)]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageIntransit(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null, DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageByLabel" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_label)]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    public override Task GetPackageByLabel(
        [Required] string label,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageLabSamples" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_labsamples)]
    [ProducesResponseType(typeof(MetrcWrapper<PackageLabSample>), StatusCodes.Status200OK)]
    public override Task GetPackageLabSamples(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null, DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageActive" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageOnHold" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_onhold)]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageOnHold(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageByIdSourceHarvests" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_id_source_harvests)]
    [ProducesResponseType(typeof(MetrcWrapper<PackageSourceHarvest>), StatusCodes.Status200OK)]
    public override Task GetPackageByIdSourceHarvests(long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageInactive" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageTypes" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_types)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetPackageTypes() => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageAdjustReasons" />
    [MapsToApi(MetrcEndpoint.get_packages_v2_adjust_reasons)]
    [ProducesResponseType(typeof(MetrcWrapper<PackageAdjustReason>), StatusCodes.Status200OK)]
    public override Task GetPackageAdjustReasons(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackages" />
    [MapsToApi(MetrcEndpoint.post_packages_v2)]
    public override Task PostPackages(
        [Required] List<PostPackagesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageTesting" />
    [MapsToApi(MetrcEndpoint.post_packages_v2_testing)]
    public override Task PostPackageTesting(
        [Required] List<PostPackageTestingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageDonationFlag" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_flag)]
    public override Task PutPackageDonationFlag(
        [Required] List<PutPackageDonationFlagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageDonationUnflag" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_donation_unflag)]
    public override Task PutPackageDonationUnflag(
        [Required] List<PutPackageDonationUnflagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackagePlantings" />
    [MapsToApi(MetrcEndpoint.post_packages_v2_plantings)]
    public override Task PostPackagePlantings(
        [Required] List<PostPackagePlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageItem" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_item)]
    public override Task PutPackageItem(
        [Required] List<PutPackageItemRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageLabTestRequired" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_labtests_required)]
    public override Task PutPackageLabTestRequired(
        [Required] List<PutPackageLabTestRequiredRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageNote" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_note)]
    public override Task PutPackageNote(
        [Required] List<PutPackageNoteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageLocation" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_location)]
    public override Task PutPackageLocation(
        [Required] List<PutPackageLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageAdjust" />
    [MapsToApi(MetrcEndpoint.post_packages_v2_adjust)]
    public override Task PostPackageAdjust(
        [Required] List<PostPackageAdjustRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageRemediate" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_remediate)]
    public override Task PutPackageRemediate(
        [Required] List<PutPackageRemediateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageTradeSampleFlag" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_flag)]
    public override Task PutPackageTradeSampleFlag(
        [Required] List<PutPackageTradeSampleFlagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageTradeSampleUnflag" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_tradesample_unflag)]
    public override Task PutPackageTradeSampleUnflag(
        [Required] List<PutPackageTradeSampleUnflagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageFinish" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_finish)]
    public override Task PutPackageFinish(
        [Required] List<PutPackageFinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageUnfinish" />
    [MapsToApi(MetrcEndpoint.put_packages_v2_unfinish)]
    public override Task PutPackageUnfinish(
        [Required] List<PutPackageUnfinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}