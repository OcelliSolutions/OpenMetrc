namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PlantController : PlantsControllerBase
{
    /// <inheritdoc cref="PlantsControllerBase.GetPlantAdditiveTypes" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_additives_types)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetPlantAdditiveTypes() => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantById" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_id)]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    public override Task GetPlantById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantByLabel" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_label)]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    public override Task GetPlantByLabel(
        [Required] string label,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantVegetative" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_vegetative)]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantVegetative(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantFlowering" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_flowering)]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantFlowering(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantOnHold" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_onhold)]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantOnHold(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantInactive" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantAdditives" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_additives)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantAdditive>), StatusCodes.Status200OK)]
    public override Task GetPlantAdditives(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantGrowthPhases" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_growthphases)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetPlantGrowthPhases(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantWasteReasons" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_reasons)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantWasteReason>), StatusCodes.Status200OK)]
    public override Task GetPlantWasteReasons(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantAdditives" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_additives)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantAdditives(
        [Required] List<PostPlantAdditivesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantAdditiveByLocation" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_additives_bylocation)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantAdditiveByLocation(
        [Required] List<PostPlantAdditiveByLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantPlantings" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_plantings)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantPlantings(
        [Required] List<PostPlantPlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantPlantBatchPackages" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_plantbatch_packages)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantPlantBatchPackages(
        [Required] List<PostPlantPlantBatchPackagesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantManicure" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_manicure)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantManicure(
        [Required] List<PostPlantManicureRequest> manicurePlantRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantLocation" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_location)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantLocation(
        [Required] List<PutPlantLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantMerge" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_merge)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantMerge(
        [Required] List<PutPlantMergeRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantSplit" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_split)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantSplit(
        [Required] List<PutPlantSplitRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantStrain" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_strain)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantStrain(
        [Required] List<PutPlantStrainRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantTag" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_tag)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantTag([Required] 
        List<PutPlantTagRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantGrowthPhase" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_growthphase)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantGrowthPhase(
        [Required] List<PutPlantGrowthPhaseRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PutPlantHarvest" />
    [MapsToApi(MetrcEndpoint.put_plants_v2_harvest)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutPlantHarvest(
        [Required] List<PutPlantHarvestRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.DeletePlants" />
    [MapsToApi(MetrcEndpoint.delete_plants_v2)]
    public override Task DeletePlants(
        [Required] List<DeletePlantsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantWaste" />
    [MapsToApi(MetrcEndpoint.post_plants_v2_waste)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostPlantWaste(
        [Required] List<PostPlantWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantWasteMethodAll" />
    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_methods_all)]
    [ProducesResponseType(typeof(MetrcWrapper<PlantWasteMethod>), StatusCodes.Status200OK)]
    public override Task GetPlantWasteMethodAll(
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;
}