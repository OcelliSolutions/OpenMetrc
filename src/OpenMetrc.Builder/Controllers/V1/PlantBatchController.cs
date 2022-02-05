namespace OpenMetrc.Builder.Controllers.V1;

[Route("plantbatches/v1")]
[ApiController]
public class PlantBatchController : ControllerBase
{
    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_id)]
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
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [ProducesResponseType(typeof(IEnumerable<PlantBatch>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [ProducesResponseType(typeof(IEnumerable<PlantBatch>), StatusCodes.Status200OK)]
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
    [MapsToApi(MetrcEndpoint.get_plantbatches_v1_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get plant batch types")]
    public ActionResult GetPlantBatchTypes() => Ok();

    [HttpPost("createplantings")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createplantings)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory })]
    [SwaggerOperation(Summary = "Create plant batch plantings")]
    public ActionResult CreatePlantBatchPlantings([Required] string licenseNumber,
        List<CreatePlantBatchPlantingRequest> createPlantBatchPlantingRequests) => Ok();

    [HttpPost("createpackages")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_createpackages)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create plant batch packages")]
    public ActionResult CreatePlantBatchPackages([Required] string licenseNumber, bool isFromMotherPlant,
        List<CreatePlantBatchPackageRequest> createPlantBatchPackageRequests) => Ok();

    [HttpPost("split")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_split)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory })]
    [SwaggerOperation(Summary = "Split a plant batch")]
    public ActionResult SplitPlantBatch([Required] string licenseNumber,
        List<SplitPlantBatchRequest> splitPlantBatchRequests) => Ok();

    [HttpPost("create/packages/frommotherplant")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory, ApiPermission.ViewPackages,
        ApiPermission.CreateSubmitDiscontinuePackages
    })]
    [SwaggerOperation(Summary = "Create packages from a mother plant for a plant batch")]
    public ActionResult CreatePackageFromPlantBatchMotherPlant([Required] string licenseNumber,
        List<CreatePlantBatchPackageRequest> createPlantBatchPackageRequests) => Ok();

    [HttpPost("changegrowthphase")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_changegrowthphase)]
    [Authorize]
    [ApiAuthorizationFilter(new[]
    {
        ApiPermission.ViewImmaturePlants, ApiPermission.ManageImmaturePlantsInventory,
        ApiPermission.ViewVegFlowerPlants, ApiPermission.ManageVegFlowerPlantsInventory
    })]
    [SwaggerOperation(Summary = "Change the growth phase for a plant batch")]
    public ActionResult ChangeGrowthPhaseForPlantBatch([Required] string licenseNumber,
        List<ChangeGrowthPhaseForPlantBatchRequest> changeGrowthPhaseForPlantBatchRequests) => Ok();

    [HttpPut("moveplantbatches")]
    [MapsToApi(MetrcEndpoint.put_plantbatches_v1_moveplantbatches)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants })]
    [SwaggerOperation(Summary = "Move a plant batch")]
    public ActionResult MovePlantBatch([Required] string licenseNumber,
        List<MovePlantBatchRequest> movePlantBatchRequests) => Ok();

    [HttpPost("additives")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_additives)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManagePlantsAdditives })]
    [SwaggerOperation(Summary = "Add plant additives to a plant batch")]
    public ActionResult AddAdditiveToPlantBatch([Required] string licenseNumber,
        List<AddAdditiveToPlantBatchRequest> addAdditiveToPlantBatchRequests) => Ok();

    [HttpPost("destroy")]
    [MapsToApi(MetrcEndpoint.post_plantbatches_v1_destroy)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewImmaturePlants, ApiPermission.DestroyImmaturePlants })]
    [SwaggerOperation(Summary = "Destroy a plant batch")]
    public ActionResult DestroyPlantBatch([Required] string licenseNumber,
        List<DestroyPlantBatchRequest> destroyPlantBatchRequests) => Ok();
}