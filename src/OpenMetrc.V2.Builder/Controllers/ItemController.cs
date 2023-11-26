namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class ItemController : ItemsControllerBase
{
    /// <inheritdoc cref="ItemsControllerBase.GetItemById" />
    [MapsToApi(MetrcEndpoint.get_items_v2_id)]
    [ProducesResponseType(typeof(Item), StatusCodes.Status200OK)]
    public override Task GetItemById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemActive" />
    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Item>), StatusCodes.Status200OK)]
    public override Task GetItemActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemInactive" />
    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Item>), StatusCodes.Status200OK)]
    public override Task GetItemInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemCategories" />
    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    [ProducesResponseType(typeof(MetrcWrapper<ItemCategory>), StatusCodes.Status200OK)]
    public override Task GetItemCategories(
        int? pageNumber = null, int? pageSize = null,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemBrands" />
    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    [ProducesResponseType(typeof(MetrcWrapper<ItemBrand>), StatusCodes.Status200OK)]
    public override Task GetItemBrands(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemPhotoById" />
    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    [ProducesResponseType(typeof(Photo), StatusCodes.Status200OK)]
    public override Task GetItemPhotoById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItems" />
    [MapsToApi(MetrcEndpoint.post_items_v2)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostItems(
        [Required] List<PostItemsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PutItems" />
    [MapsToApi(MetrcEndpoint.put_items_v2)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutItems(
        [Required] List<PutItemsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItemPhoto" />
    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostItemPhoto(
        [Required] List<PostItemPhotoRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.DeleteItemById" />
    [MapsToApi(MetrcEndpoint.delete_items_v2_id)]
    public override Task DeleteItemById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.DeleteItemBrandById" />
    [MapsToApi(MetrcEndpoint.delete_items_v2_brand_id)]
    public override Task DeleteItemBrandById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItemBrand" />
    [MapsToApi(MetrcEndpoint.post_items_v2_brand)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostItemBrand(
        [Required] List<PostItemBrandRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PutItemBrand" />
    [MapsToApi(MetrcEndpoint.put_items_v2_brand)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PutItemBrand(
        [Required] List<PutItemBrandRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;
}