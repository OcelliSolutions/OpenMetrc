namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class HarvestController : HarvestsControllerBase
{
    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v1_id)]
    [ProducesResponseType(typeof(Harvest), StatusCodes.Status200OK)]
    public override Task GetHarvestById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestActive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v1_onhold)]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestOnHold(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v1_waste_types)]
    [ProducesResponseType(typeof(IEnumerable<HarvestWasteType>), StatusCodes.Status200OK)]
    public override Task GetHarvestWasteTypes() => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages)]
    public override Task PostHarvestCreatePackages(
        [Required] List<PostHarvestCreatePackagesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.post_harvests_v1_create_packages_testing)]
    public override Task PostHarvestCreatePackageTesting(
        [Required] List<PostHarvestCreatePackageTestingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.put_harvests_v1_move)]
    public override Task PutHarvestMove(
        [Required] List<PutHarvestMoveRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.post_harvests_v1_removewaste)]
    public override Task PostHarvestRemoveWaste(
        [Required] List<PostHarvestRemoveWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.put_harvests_v1_rename)]
    public override Task PutHarvestRename(
        [Required] List<PutHarvestRenameRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.post_harvests_v1_finish)]
    public override Task PostHarvestFinish(
        [Required] List<PostHarvestFinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.post_harvests_v1_unfinish)]
    public override Task PostHarvestUnfinish(
        [Required] List<PostHarvestUnfinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}