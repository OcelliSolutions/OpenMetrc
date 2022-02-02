namespace OpenMetrc.Builder.Controllers.V1;

[Route("items/v1")]
[ApiController]
public class ItemController : ControllerBase
{
    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
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
    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(IEnumerable<Item>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active items")]
    public ActionResult GetActiveItems(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active items.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("categories")]
    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<ItemCategory>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get item categories")]
    public ActionResult GetItemCategories(
        [SwaggerParameter(Description =
            "If specified, the Categories will be retrived for the specified License Number. If not specified, the all Item Categories will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("brands")]
    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
    [ProducesResponseType(typeof(IEnumerable<ItemBrand>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get item brands")]
    public ActionResult GetItemBrands(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active item brands.")]
        string licenseNumber
    ) => Ok();

    [HttpPost("create")]
    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Create items")]
    public ActionResult CreateItem([Required] string licenseNumber, List<CreateItemRequest> createItemRequests) => Ok();

    [HttpPost("update")]
    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Update items")]
    public ActionResult UpdateItem([Required] string licenseNumber, List<CreateItemRequest> createItemRequests) => Ok();

    [HttpDelete("{id:long}")]
    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageItems })]
    [SwaggerOperation(Summary = "Delete an item")]
    public ActionResult DeleteItem([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Item ID")]
        long id) => Ok();
}