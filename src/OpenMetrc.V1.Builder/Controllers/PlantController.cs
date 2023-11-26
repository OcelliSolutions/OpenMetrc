namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PlantController : PlantsControllerBase
{
    /// <inheritdoc cref="PlantsControllerBase.GetPlantAdditiveTypes" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetPlantAdditiveTypes() => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantById" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    public override Task GetPlantById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantByLabel" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    public override Task GetPlantByLabel(
        [Required] string label,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantVegetative" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantVegetative(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantFlowering" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantFlowering(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantOnHold" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantOnHold(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantInactive" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    public override Task GetPlantInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantAdditives" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    [ProducesResponseType(typeof(IEnumerable<PlantAdditive>), StatusCodes.Status200OK)]
    public override Task GetPlantAdditives(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantGrowthPhases" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetPlantGrowthPhases(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantWasteReasons" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    [ProducesResponseType(typeof(IEnumerable<PlantWasteReason>), StatusCodes.Status200OK)]
    public override Task GetPlantWasteReasons(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantAdditives" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    public override Task PostPlantAdditives(
        [Required] List<PostPlantAdditivesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantAdditiveByLocation" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    public override Task PostPlantAdditiveByLocation(
        [Required] List<PostPlantAdditiveByLocationRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantCreatePlantings" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    public override Task PostPlantCreatePlantings(
        [Required] List<PostPlantCreatePlantingsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantCreatePlantBatchPackages" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    public override Task PostPlantCreatePlantBatchPackages(
        [Required] List<PostPlantCreatePlantBatchPackagesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantManicurePlants" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    public override Task PostPlantManicurePlants(
        [Required] List<PostPlantManicurePlantsRequest> manicurePlantRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantMovePlants" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    public override Task PostPlantMovePlants(
        [Required] List<PostPlantMovePlantsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantChangeGrowthPhases" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    public override Task PostPlantChangeGrowthPhases(
        [Required] List<PostPlantChangeGrowthPhasesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantHarvestPlants" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    public override Task PostPlantHarvestPlants(
        [Required] List<PostPlantHarvestPlantsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.DeletePlants" />
    [MapsToApi(MetrcEndpoint.delete_plants_v1)]
    public override Task DeletePlants(
        [Required] List<DeletePlantsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.PostPlantWaste" />
    [MapsToApi(MetrcEndpoint.post_plants_v1_waste)]
    public override Task PostPlantWaste(
        [Required] List<PostPlantWasteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="PlantsControllerBase.GetPlantWasteMethodAll" />
    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods_all)]
    [ProducesResponseType(typeof(IEnumerable<PlantWasteMethod>), StatusCodes.Status200OK)]
    public override Task GetPlantWasteMethodAll() => Task.CompletedTask;
}