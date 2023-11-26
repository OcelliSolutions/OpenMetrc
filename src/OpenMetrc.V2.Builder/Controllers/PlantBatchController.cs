namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PlantBatchController : PlantBatchesControllerBase
{
    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchById" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_id)]
    [ProducesResponseType(typeof(PlantBatch), StatusCodes.Status200OK)]
    public override Task GetPlantBatchById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchActive" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatch>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchInactive" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatch>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchTypes" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_types)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchTypes(
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.DeletePlantBatches" />
    [MapsToApi(MetrcEndpoint.delete_plantbatches_v2)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task DeletePlantBatches(
        [Required] List<DeletePlantBatchesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.GetPlantBatchWasteReasons" />
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_waste_reasons)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatchWasteReason>), StatusCodes.Status200OK)]
    public override Task GetPlantBatchWasteReasons(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchWaste" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_waste)]
    public override Task PostPlantBatchWaste(
        [Required] List<PostPlantBatchWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchAdjust" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_adjust)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantBatchAdjust(
        [Required] List<PostPlantBatchAdjustRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchAdditives" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_additives)]
    public override Task PostPlantBatchAdditives(
        [Required] List<PostPlantBatchAdditivesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchPlantings" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_plantings)]
    public override Task PostPlantBatchPlantings(
        [Required] List<PostPlantBatchPlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchPackages" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages)]
    public override Task PostPlantBatchPackages(
        [Required] List<PostPlantBatchPackagesRequest> request,
        [Required] string licenseNumber,
        bool? isFromMotherPlant = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchPackageFromMotherPlant" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant)]
    public override Task PostPlantBatchPackageFromMotherPlant(
        [Required] List<PostPlantBatchPackageFromMotherPlantRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchSplit" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_split)]
    public override Task PostPlantBatchSplit(
        [Required] List<PostPlantBatchSplitRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PostPlantBatchGrowthPhase" />
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_growthphase)]
    public override Task PostPlantBatchGrowthPhase(
        [Required] List<PostPlantBatchGrowthPhaseRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PutPlantBatchLocation" />
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_location)]
    public override Task PutPlantBatchLocation(
        [Required] List<PutPlantBatchLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PutPlantBatchStrain" />
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_strain)]
    public override Task PutPlantBatchStrain(
        [Required] List<PutPlantBatchStrainRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantBatchesControllerBase.PutPlantBatchTag" />
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_tag)]
    public override Task PutPlantBatchTag(
        [Required] List<PutPlantBatchTagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}