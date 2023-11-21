using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("plants/v2")]
[ApiVersion("2")]
[ApiController]
public class PlantController : ControllerBase
{
    [HttpGet("additives/types")]
    [MapsToApi(MetrcEndpoint.get_plants_v2_additives_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant additive types")]
    public ActionResult GetPlantAdditivesTypes() => Ok();

    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_plants_v2_id)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_label)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_vegetative)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_flowering)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_onhold)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants })]
    [ProducesResponseType(typeof(MetrcWrapper<Plant>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewManagePlantsAdditives })]
    [ProducesResponseType(typeof(MetrcWrapper<PlantAdditive>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plants_v2_growthphases)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant growth phases")]
    public ActionResult GetPlantGrowthPhases(
        [Required] [SwaggerParameter(Description = "The license number of the facility for plant growth phases.")]
        string licenseNumber) => Ok();

    [HttpPut("tag")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_tag)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Tag plants")]
    public ActionResult TagPlants(
        [Required] [SwaggerParameter(Description = "The license number of the facility for plant growth phases.")]
        string licenseNumber,
        [Required] List<TagPlantRequest> tagPlantRequests) => Ok();

    [HttpPut("strain")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_strain)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Update plants strains")]
    public ActionResult UpdatePlantsStrains(
        [Required] [SwaggerParameter(Description = "The license number of the facility for which to update the list of plant strains.")]
        string licenseNumber,
        [Required] List<UpdatePlantStrainRequest> updatePlantStrainRequest) => Ok();

    [HttpGet("waste/reasons")]
    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_reasons)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<PlantWasteReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant waste reasons")]
    public ActionResult GetPlantWasteReasons(
        [Required] [SwaggerParameter(Description = "The license number of the facility for plant waste reasons.")]
        string licenseNumber) => Ok();

    [HttpPost("additives")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add additives to a plant")]
    public ActionResult AddAdditiveToPlant([Required] string licenseNumber,
        [Required] List<AddAdditiveToPlantRequest> addAdditiveToPlantRequests) => Ok();

    [HttpPost("additives/bylocation")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_additives_bylocation)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlants, ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add additives to plants by location")]
    public ActionResult AddAdditiveToPlantByLocation([Required] string licenseNumber,
        [Required] List<AddAdditiveToPlantByLocationRequest> addAdditiveToPlantByLocationRequests) => Ok();

    [HttpPost("plantings")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_plantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory,
        ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory
    })]
    [SwaggerOperation(Summary = "Add additives to plants by location")]
    public ActionResult CreatePlantingOfPlant([Required] string licenseNumber,
        [Required] List<CreatePlantingOfPlantRequest> createPlantingOfPlantRequests) => Ok();

    [HttpPost("plantbatch/packages")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_plantbatch_packages)]
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

    [HttpPost("manicure")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_manicure)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManicureHarvestVegFlowerPlants })]
    [SwaggerOperation(Summary = "Manicure plants")]
    public ActionResult ManicurePlant([Required] string licenseNumber,
        [Required] List<ManicurePlantRequest> manicurePlantRequest) => Ok();

    [HttpPut("location")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_location)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Move a plant")]
    public ActionResult MovePlant([Required] string licenseNumber,
        [Required] List<MovePlantRequest> movePlantRequests) => Ok();

    [HttpPut("growthphase")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_growthphase)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Change a plant's growth phase")]
    public ActionResult ChangePlantGrowthPhase([Required] string licenseNumber,
        [Required] List<ChangePlantGrowthPhaseRequest> changePlantGrowthPhaseRequests) => Ok();

    [HttpPut("harvest")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_harvest)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManicureHarvestVegFlowerPlants })]
    [SwaggerOperation(Summary = "Harvest plants")]
    public ActionResult HarvestPlant([Required] string licenseNumber,
        [Required] List<HarvestPlantRequest> harvestPlantRequests) => Ok();

    [HttpPut("merge")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_merge)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManicureHarvestVegFlowerPlants })]
    [SwaggerOperation(Summary = "Merge plants")]
    public ActionResult MergePlant([Required] string licenseNumber,
        [Required] List<MergePlantRequest> mergePlantRequests) => Ok();

    [HttpDelete]
    [MapsToApi(MetrcEndpoint.delete_plants_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.DestroyVegFlowerPlants })]
    [SwaggerOperation(Summary = "Destroy a plant")]
    public ActionResult DeletePlant([Required] string licenseNumber,
        [Required] List<DestroyPlantRequest> destroyPlantRequests) =>
        Ok();

    [HttpPost("waste")]
    [MapsToApi(MetrcEndpoint.post_plants_v2_waste)]
    [Authorize]
    [ApiAuthorizationFilter]
    [SwaggerOperation(Summary = "Create plant waste")]
    public ActionResult CreatePlantWaste([Required] string licenseNumber,
        [Required] List<CreatePlantWasteRequest> destroyPlantRequests) => Ok();

    [HttpGet("waste/methods/all")]
    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_methods_all)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<PlantWasteMethod>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all plant waste method properties")]
    public ActionResult GetPlantWasteMethodsAll() => Ok();

    [HttpPut("split")]
    [MapsToApi(MetrcEndpoint.put_plants_v2_split)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPlant })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Split plants")]
    public ActionResult SplitPlant([Required] string licenseNumber,
        [Required] List<SplitPlantRequest> splitPlantRequests) => Ok();
}