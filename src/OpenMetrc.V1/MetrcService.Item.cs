namespace OpenMetrc.V1;

public partial class MetrcService : IItemClient
{
    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    Task<Item> IItemClient.GetItemByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : ItemClient.GetItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    Task IItemClient.DeleteItemByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    Task<ICollection<Item>?> IItemClient.
        GetItemActiveAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>?>(new List<Item>())
            : ItemClient.GetItemActiveAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_inactive)]
    Task<ICollection<Item>?> IItemClient.GetItemInactiveAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>?>(new List<Item>())
            : ItemClient.GetItemInactiveAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    Task<ICollection<ItemCategory>?> IItemClient.GetItemCategoriesAsync(string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemCategory>?>(new List<ItemCategory>())
            : ItemClient.GetItemCategoriesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    Task<ICollection<ItemBrand>?> IItemClient.GetItemBrandsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemBrand>?>(new List<ItemBrand>())
            : ItemClient.GetItemBrandsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_photo_id)]
    Task<Photo> IItemClient.GetItemPhotoByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Photo())
            : ItemClient.GetItemPhotoByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    Task IItemClient.PostItemCreateAsync(string licenseNumber, IEnumerable<PostItemCreateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemCreateAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    Task IItemClient.PostItemUpdateAsync(string licenseNumber, IEnumerable<PostItemUpdateRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemUpdateAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_photo)]
    Task IItemClient.PostItemPhotoAsync(string licenseNumber, IEnumerable<PostItemPhotoRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemPhotoAsync(licenseNumber, body, cancellationToken);
}