namespace OpenMetrc.Builder.Controllers.V1;

[Route("plants/v1")]
[ApiController]
public class PlantController : ControllerBase
{
    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific plant by id")]
    public ActionResult GetPlantById(
        [Required] [SwaggerParameter(Description = "Plant ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Plant will be validated against the specified License Number. If not specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("{label}")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(Plant), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific plant by label")]
    public ActionResult GetPlantByLabel(
        [Required] [SwaggerParameter(Description = "Plant Label")]
        string label,
        [SwaggerParameter(Description =
            "If specified, the Plant will be validated against the specified License Number. If not specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("vegetative")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plants in an vegetating status")]
    public ActionResult GetVegetativePlants(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of vegetating plants.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("flowering")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plants in an flowering status")]
    public ActionResult GetFloweringPlants(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of flowering plants.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("onhold")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plants in an onhold status")]
    public ActionResult GetOnHoldPlants(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of onhold plants.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(IEnumerable<Plant>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plants in an inactive status")]
    public ActionResult GetInactivePlants(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive plants.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("additives")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewManagePlantsAdditives })]
    [ProducesResponseType(typeof(IEnumerable<PlantAdditive>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant additives")]
    public ActionResult GetPlantAdditives(
        [Required]
        [SwaggerParameter(Description = "The license number of the facility for which to record plant additives.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("growthphases")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant growth phases")]
    public ActionResult GetPlantGrowthPhases(
        [Required] [SwaggerParameter(Description = "The license number of the facility for plant growth phases.")]
        string licenseNumber) => Ok();

    [HttpGet("additives/types")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant additive types")]
    public ActionResult GetPlantAdditivesTypes() => Ok();

    [HttpGet("waste/methods")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<PlantWasteMethod>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant waste methods")]
    public ActionResult GetPlantWasteMethods() => Ok();

    [HttpGet("waste/reasons")]
    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<PlantWasteReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant waste reasons")]
    public ActionResult GetPlantWasteReasons(
        [Required] [SwaggerParameter(Description = "The license number of the facility for plant waste reasons.")]
        string licenseNumber) => Ok();

    [HttpPost("moveplants")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Move a plant")]
    public ActionResult MovePlant([Required] string licenseNumber,
        [Required] List<MovePlantRequest> movePlantRequests) => Ok();

    [HttpPost("changegrowthphases")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Change a plant's growth phase")]
    public ActionResult ChangePlantGrowthPhase([Required] string licenseNumber,
        [Required] List<ChangePlantGrowthPhaseRequest> changePlantGrowthPhaseRequests) => Ok();

    [HttpPost("destroyplants")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_destroyplants)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.DestroyVegFlowerPlants })]
    [SwaggerOperation(Summary = "Destroy a plant")]
    public ActionResult DestroyPlant([Required] string licenseNumber,
        [Required] List<DestroyPlantRequest> destroyPlantRequests) =>
        Ok();

    [HttpPost("additives")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add additives to a plant")]
    public ActionResult AddAdditiveToPlant([Required] string licenseNumber,
        [Required] List<AddAdditiveToPlantRequest> addAdditiveToPlantRequests) => Ok();

    [HttpPost("additives/bylocation")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlants, ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add additives to plants by location")]
    public ActionResult AddAdditiveToPlantByLocation([Required] string licenseNumber,
        [Required] List<AddAdditiveToPlantByLocationRequest> addAdditiveToPlantByLocationRequests) => Ok();

    [HttpPost("create/plantings")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory,
        ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory
    })]
    [SwaggerOperation(Summary = "Add additives to plants by location")]
    public ActionResult CreatePlantingOfPlant([Required] string licenseNumber,
        [Required] List<CreatePlantingOfPlantRequest> createPlantingOfPlantRequests) => Ok();

    [HttpPost("create/plantbatch/packages")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory,
        ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create plant batch from plants")]
    public ActionResult CreatePlantBatchFromPlantPackage([Required] string licenseNumber,
        [Required] List<CreatePlantBatchFromPlantPackageRequest> createPlantBatchFromPlantPackageRequests) => Ok();

    [HttpPost("harvestplants")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManicureHarvestVegFlowerPlants })]
    [SwaggerOperation(Summary = "Harvest plants")]
    public ActionResult HarvestPlant([Required] string licenseNumber,
        [Required] List<HarvestPlantRequest> harvestPlantRequests) =>
        Ok();

    [HttpPost("manicureplants")]
    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManicureHarvestVegFlowerPlants })]
    [SwaggerOperation(Summary = "Manicure plants")]
    public ActionResult ManicurePlant([Required] string licenseNumber,
        [Required] List<ManicurePlantRequest> manicurePlantRequest) => Ok();
}