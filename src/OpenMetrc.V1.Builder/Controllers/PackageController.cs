namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PackageController : PackagesControllerBase
{
    /// <inheritdoc cref="PackagesControllerBase.GetPackageById" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_id)]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    public override Task GetPackageById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageByLabel" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_label)]
    [ProducesResponseType(typeof(Package), StatusCodes.Status200OK)]
    public override Task GetPackageByLabel(
        [Required] string label,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageActive" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageActive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageOnHold" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_onhold)]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageOnHold(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageInactive" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<Package>), StatusCodes.Status200OK)]
    public override Task GetPackageInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageTypes" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_types)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetPackageTypes() => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.GetPackageAdjustReasons" />
    [MapsToApi(MetrcEndpoint.get_packages_v1_adjust_reasons)]
    [ProducesResponseType(typeof(IEnumerable<PackageAdjustReason>), StatusCodes.Status200OK)]
    public override Task GetPackageAdjustReasons(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageCreate" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_create)]
    public override Task PostPackageCreate(
        [Required] List<PostPackageCreateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageCreateTesting" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_create_testing)]
    public override Task PostPackageCreateTesting(
        [Required] List<PostPackageCreateTestingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageCreatePlantings" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_create_plantings)]
    public override Task PostPackageCreatePlantings(
        [Required] List<PostPackageCreatePlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageChangeItem" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_change_item)]
    public override Task PostPackageChangeItem(
        [Required] List<PostPackageChangeItemRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PutPackageChangeNote" />
    [MapsToApi(MetrcEndpoint.put_packages_v1_change_note)]
    public override Task PutPackageChangeNote(
        [Required] List<PutPackageChangeNoteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageChangeLocations" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_change_locations)]
    public override Task PostPackageChangeLocations(
        [Required] List<PostPackageChangeLocationsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageAdjust" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_adjust)]
    public override Task PostPackageAdjust(
        [Required] List<PostPackageAdjustRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageRemediate" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_remediate)]
    public override Task PostPackageRemediate(
        [Required] List<PostPackageRemediateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageFinish" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_finish)]
    public override Task PostPackageFinish(
        [Required] List<PostPackageFinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PackagesControllerBase.PostPackageUnfinish" />
    [MapsToApi(MetrcEndpoint.post_packages_v1_unfinish)]
    public override Task PostPackageUnfinish(
        [Required] List<PostPackageUnfinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}