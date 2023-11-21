using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("plantbatches/v2")]
[ApiVersion("2")]
[ApiController]
public class PlantBatchController : ControllerBase
{
    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [ProducesResponseType(typeof(PlantBatch), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific plant batch by id")]
    public ActionResult GetPlantBatchById(
        [Required] [SwaggerParameter(Description = "Plant Batch ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Plant Batch will be validated against the specified License Number. If not specified, the Plant Batch will be validated against all of the User's current Facilities. Please note that if the Plant Batch is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatch>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batches in an active status")]
    public ActionResult GetActivePlantBatches(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active plant batches.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatch>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batches in an inactive status")]
    public ActionResult GetInactivePlantBatches(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive plant batches.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batch types")]
    public ActionResult GetPlantBatchTypes() => Ok();

    [HttpDelete]
    [MapsToApi(MetrcEndpoint.delete_plantbatches_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.DestroyImmaturePlants })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Delete plant batches")]
    public ActionResult DeletePlantBatches([Required] string licenseNumber,
        [Required] List<DestroyPlantBatchRequest> destroyPlantBatchRequests) => Ok();
    
    [HttpGet("waste/reasons")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v2_waste_reasons)]
    [Authorize]
    [ApiAuthorizationFilter()]
    [ProducesResponseType(typeof(MetrcWrapper<PlantBatchWasteReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batch waste reasons")]
    public ActionResult GetPlantBatchWasteReasons(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of plant batch waste reasons.")]
        string licenseNumber
    ) => Ok();

    [HttpPost("waste")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_waste)]
    [Authorize]
    [ApiAuthorizationFilter(new [] { ApiPermission.ManagePlantsWaste })]
    [SwaggerOperation(Summary = "Create plant batch waste")]
    public ActionResult CreatePlantBatchWaste([Required] string licenseNumber,
        [Required] List<CreatePlantBatchWasteRequest> createPlantBatchWasteRequests
    ) => Ok();

    [HttpPost("adjust")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_adjust)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory })]
    [ProducesResponseType(typeof(MetrcWrapper<CreatePlantBatchWasteRequest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batch waste reasons")]
    public ActionResult AdjustPlantBatch([Required] string licenseNumber,
        [Required] List<AdjustPlantBatchRequest> adjustPlantBatchRequests
    ) => Ok();

    [HttpPost("additives")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add plant additives to a plant batch")]
    public ActionResult AddAdditiveToPlantBatch([Required] string licenseNumber,
        [Required] List<AddAdditiveToPlantBatchRequest> addAdditiveToPlantBatchRequests) => Ok();

    [HttpPost("plantings")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_plantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory })]
    [SwaggerOperation(Summary = "Create plant batch plantings")]
    public ActionResult CreatePlantBatchPlantings([Required] string licenseNumber,
        [Required] List<CreatePlantBatchPlantingRequest> createPlantBatchPlantingRequests) => Ok();

    [HttpPost("packages")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create plant batch packages")]
    public ActionResult CreatePlantBatchPackages([Required] string licenseNumber, bool isFromMotherPlant,
        [Required] List<CreatePlantBatchPackageRequest> createPlantBatchPackageRequests) => Ok();

    [HttpPost("packages/frommotherplant")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create packages from a mother plant for a plant batch")]
    public ActionResult CreatePackageFromPlantBatchMotherPlant([Required] string licenseNumber,
        [Required] List<CreatePlantBatchPackageRequest> createPlantBatchPackageRequests) => Ok();

    [HttpPost("split")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_split)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory })]
    [SwaggerOperation(Summary = "Split a plant batch")]
    public ActionResult SplitPlantBatch([Required] string licenseNumber,
        [Required] List<SplitPlantBatchRequest> splitPlantBatchRequests) => Ok();

    [HttpPost("growthphase")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v2_growthphase)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory,
        ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory
    })]
    [SwaggerOperation(Summary = "Change the growth phase for a plant batch")]
    public ActionResult ChangeGrowthPhaseForPlantBatch([Required] string licenseNumber,
        [Required] List<ChangeGrowthPhaseForPlantBatchRequest> changeGrowthPhaseForPlantBatchRequests) => Ok();

    [HttpPut("tag")]
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_tag)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Tag a plant batch")]
    public ActionResult TagPlantBatch([Required] string licenseNumber,
        [Required] List<TagPlantBatchRequest> tagPlantBatchRequests) => Ok();

    [HttpPut("strain")]
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_strain)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory })]
    [SwaggerOperation(Summary = "Update plant batch strains")]
    public ActionResult UpdatePlantBatchStrain([Required] string licenseNumber,
        [Required] List<UpdatePlantBatchStrainRequest> updatePlantBatchStrainRequests) => Ok();

    [HttpPut("location")]
    [MapsToApi(MetrcEndpoint.put_plantbatches_v2_location)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [SwaggerOperation(Summary = "Move a plant batch")]
    public ActionResult MovePlantBatch([Required] string licenseNumber,
        [Required] List<MovePlantBatchRequest> movePlantBatchRequests) => Ok();
}