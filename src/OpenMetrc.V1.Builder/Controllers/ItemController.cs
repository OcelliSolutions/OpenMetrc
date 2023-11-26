namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class ItemController : ItemsControllerBase
{
    /// <inheritdoc cref="ItemsControllerBase.GetItemById" />
    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    [ProducesResponseType(typeof(Item), StatusCodes.Status200OK)]
    public override Task GetItemById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemActive" />
    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Item>), StatusCodes.Status200OK)]
    public override Task GetItemActive(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemInactive" />
    [MapsToApi(MetrcEndpoint.get_items_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<Item>), StatusCodes.Status200OK)]
    public override Task GetItemInactive(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemCategories" />
    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    [ProducesResponseType(typeof(IEnumerable<ItemCategory>), StatusCodes.Status200OK)]
    public override Task GetItemCategories(
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemBrands" />
    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    [ProducesResponseType(typeof(IEnumerable<ItemBrand>), StatusCodes.Status200OK)]
    public override Task GetItemBrands(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.GetItemPhotoById" />
    [MapsToApi(MetrcEndpoint.get_items_v1_photo_id)]
    [ProducesResponseType(typeof(Photo), StatusCodes.Status200OK)]
    public override Task GetItemPhotoById(
        [Required] long id,
        string? licenseNumber = null
    ) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItemCreate" />
    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    public override Task PostItemCreate(
        [Required] List<PostItemCreateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItemUpdate" />
    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    public override Task PostItemUpdate(
        [Required] List<PostItemUpdateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.PostItemPhoto" />
    [MapsToApi(MetrcEndpoint.post_items_v1_photo)]
    [ProducesResponseType(typeof(IEnumerable<long>), StatusCodes.Status200OK)]
    public override Task PostItemPhoto(
        [Required] List<PostItemPhotoRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ItemsControllerBase.DeleteItemById" />
    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    public override Task DeleteItemById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}