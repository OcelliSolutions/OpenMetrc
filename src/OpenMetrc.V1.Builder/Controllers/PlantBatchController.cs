namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PlantBatchController : PlantBatchesControllerBase
{
    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchById" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
    [ProducesResponseType(typeof(PlantBatch), StatusCodes.Status200OK)]
    public override Task GetPlantBatchById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchActive" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<PlantBatch>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchActive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchInactive" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<PlantBatch>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchTypes" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchTypes() => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.DeletePlantBatches" />
    [MapsToApi(MetrcEndpoint.delete_plantbatches_v1)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task DeletePlantBatches(
        [Required] List<DeletePlantBatchesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchWasteReasons" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_waste_reasons)]
    [ProducesResponseType(typeof(IEnumerable<PlantBatchWasteReason>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchWasteReasons(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchWaste" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_waste)]
    public override Task PostPlantBatchWaste(
        [Required] List<PostPlantBatchWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchAdjust" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_adjust)]
    public override Task PostPlantBatchAdjust(
        [Required] List<PostPlantBatchAdjustRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchAdditives" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    public override Task PostPlantBatchAdditives(
        [Required] List<PostPlantBatchAdditivesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchCreatePlantings" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    public override Task PostPlantBatchCreatePlantings(
        [Required] List<PostPlantBatchCreatePlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchCreatePackages" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    public override Task PostPlantBatchCreatePackages(
        [Required] List<PostPlantBatchCreatePackagesRequest> request,
        [Required] string licenseNumber,
        bool? isFromMotherPlant = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchCreatePackageFromMotherPlant" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    public override Task PostPlantBatchCreatePackageFromMotherPlant(
        [Required] List<PostPlantBatchCreatePackageFromMotherPlantRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchSplit" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    public override Task PostPlantBatchSplit(
        [Required] List<PostPlantBatchSplitRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchChangeGrowthPhase" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    public override Task PostPlantBatchChangeGrowthPhase(
        [Required] List<PostPlantBatchChangeGrowthPhaseRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PutPlantBatchMovePlantBatches" />
    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    public override Task PutPlantBatchMovePlantBatches(
        [Required] List<PutPlantBatchMovePlantBatchesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}