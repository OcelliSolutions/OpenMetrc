using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("items/v2")]
[ApiVersion("2")]
[ApiController]
public class ItemController : ControllerBase
{
    [HttpGet("{id}")]
    [MapsToApi(MetrcEndpoint.get_items_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(Item), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific item by id")]
    public ActionResult GetItemById(
        [Required] [SwaggerParameter(Description = "Item ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Item will be validated against the specified License Number. If not specified, the Item will be validated against all of the User's current Facilities. Please note that if the Item is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(MetrcWrapper<Item>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active items")]
    public ActionResult GetActiveItems(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active items.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(MetrcWrapper<Item>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive items")]
    public ActionResult GetInactiveItems(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive items.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("categories")]
    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<ItemCategory>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get item categories")]
    public ActionResult GetItemCategories(
        [SwaggerParameter(Description =
            "If specified, the Categories will be retrieved for the specified License Number. If not specified, the all Item Categories will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("brands")]
    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(MetrcWrapper<ItemBrand>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get item brands")]
    public ActionResult GetItemBrands(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active item brands.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("photo/{id}")]
    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(Photo), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get item photo")]
    public ActionResult GetItemPhoto(
        [Required] long id,
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the item photo.")]
        string licenseNumber
    ) => Ok();

    [HttpPost]
    [MapsToApi(MetrcEndpoint.post_items_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Create items")]
    public ActionResult CreateItem([Required] string licenseNumber,
        [Required] List<CreateItemRequest> createItemRequests) => Ok();

    [HttpPut]
    [MapsToApi(MetrcEndpoint.put_items_v2)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Update items")]
    public ActionResult UpdateItem([Required] string licenseNumber,
        [Required] List<CreateItemRequest> createItemRequests) => Ok();

    [HttpPost("photo")]
    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(MetrcWrapper<IReadOnlyList<long>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Create Photo")]   
    public ActionResult CreatePhoto([Required] string licenseNumber,
        [Required] List<CreatePhotoRequest> createPhotoRequests) => Ok();

    [HttpDelete("{id}")]
    [MapsToApi(MetrcEndpoint.delete_items_v2_id)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Delete an item")]
    public ActionResult DeleteItem([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Item ID")]
        long id) => Ok();

    [HttpDelete("brand/{id}")]
    [MapsToApi(MetrcEndpoint.delete_items_v2_brand_id)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Delete a brand")]
    public ActionResult DeleteItemBrand([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Brand ID")]
        long id) => Ok();

    [HttpPost("brand")]
    [MapsToApi(MetrcEndpoint.post_items_v2_brand)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Create brands")]
    public ActionResult CreateBrand([Required] string licenseNumber,
        [Required] List<CreateBrandRequest> createBrandRequests) => Ok();

    [HttpPut("brand")]
    [MapsToApi(MetrcEndpoint.put_items_v2_brand)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Update brands")]
    public ActionResult UpdateBrand([Required] string licenseNumber,
        [Required] List<UpdateBrandRequest> updateBrandRequests) => Ok();
}