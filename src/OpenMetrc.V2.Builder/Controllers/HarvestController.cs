namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class HarvestController : HarvestsControllerBase
{
    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestById" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_id)]
    [ProducesResponseType(typeof(Harvest), StatusCodes.Status200OK)]
    public override Task GetHarvestById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestActive" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestOnHold" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_onhold)]
    [ProducesResponseType(typeof(MetrcWrapper<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestOnHold(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestInactive" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Harvest>), StatusCodes.Status200OK)]
    public override Task GetHarvestInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestWaste" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste)]
    [ProducesResponseType(typeof(MetrcWrapper<HarvestWaste>), StatusCodes.Status200OK)]
    public override Task GetHarvestWaste(
        [Required] string licenseNumber,
        [Required] long harvestId,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.GetHarvestWasteTypes" />
    [MapsToApi(MetrcEndpoint.get_harvests_v2_waste_types)]
    [ProducesResponseType(typeof(MetrcWrapper<HarvestWasteType>), StatusCodes.Status200OK)]
    public override Task GetHarvestWasteTypes(
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PostHarvestPackages" />
    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostHarvestPackages(
        [Required] List<PostHarvestPackagesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PostHarvestPackageTesting" />
    [MapsToApi(MetrcEndpoint.post_harvests_v2_packages_testing)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostHarvestPackageTesting(
        [Required] List<PostHarvestPackageTestingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PutHarvestLocation" />
    [MapsToApi(MetrcEndpoint.put_harvests_v2_location)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutHarvestLocation(
        [Required] List<PutHarvestLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PostHarvestWaste" />
    [MapsToApi(MetrcEndpoint.post_harvests_v2_waste)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostHarvestWaste(
        [Required] List<PostHarvestWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PutHarvestRename" />
    [MapsToApi(MetrcEndpoint.put_harvests_v2_rename)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutHarvestRename(
        [Required] List<PutHarvestRenameRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PutHarvestFinish" />
    [MapsToApi(MetrcEndpoint.put_harvests_v2_finish)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutHarvestFinish(
        [Required] List<PutHarvestFinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PutHarvestUnfinish" />
    [MapsToApi(MetrcEndpoint.put_harvests_v2_unfinish)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutHarvestUnfinish(
        [Required] List<PutHarvestUnfinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.PutHarvestRestoreHarvestedPlants" />
    [MapsToApi(MetrcEndpoint.put_harvests_v2_restore_harvestedplants)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutHarvestRestoreHarvestedPlants(
        [Required] List<PutHarvestRestoreHarvestedPlantsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="HarvestsControllerBase.DeleteHarvestWasteById" />
    [MapsToApi(MetrcEndpoint.delete_harvests_v2_waste_id)]
    public override Task DeleteHarvestWasteById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}