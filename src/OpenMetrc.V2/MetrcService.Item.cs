namespace OpenMetrc.V2;

public partial class MetrcService : IItemClient
{
    [MapsToApi(MetrcEndpoint.get_items_v2_id)]
    Task<Item> IItemClient.GetItemByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : ItemClient.GetItemByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_id)]
    Task<Item> IItemClient.GetItemByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : ItemClient.GetItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_items_v2_id)]
    Task IItemClient.DeleteItemByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_items_v2_id)]
    Task IItemClient.DeleteItemByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    Task<ItemMetrcWrapper> IItemClient.GetItemActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetItemActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    Task<ItemMetrcWrapper> IItemClient.GetItemActiveAsync(string licenseNumber,
            int? pageNumber, int? pageSize,
            DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
            CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetItemActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    Task<ItemMetrcWrapper> IItemClient.GetItemInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetItemInactiveAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    Task<ItemMetrcWrapper> IItemClient.GetItemInactiveAsync(string licenseNumber,
            int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetItemInactiveAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    Task<ItemCategoryMetrcWrapper> IItemClient.GetItemCategoriesAsync(int? pageNumber, int? pageSize, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemCategoryMetrcWrapper())
            : ItemClient.GetItemCategoriesAsync(pageNumber, pageSize, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    Task<ItemCategoryMetrcWrapper> IItemClient.GetItemCategoriesAsync(
        int? pageNumber, int? pageSize, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemCategoryMetrcWrapper())
            : ItemClient.GetItemCategoriesAsync(pageNumber, pageSize, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    Task<ItemBrandMetrcWrapper> IItemClient.GetItemBrandsAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemBrandMetrcWrapper())
            : ItemClient.GetItemBrandsAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    Task<ItemBrandMetrcWrapper> IItemClient.GetItemBrandsAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemBrandMetrcWrapper())
            : ItemClient.GetItemBrandsAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    Task<Photo> IItemClient.GetItemPhotoByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Photo())
            : ItemClient.GetItemPhotoByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    Task<Photo> IItemClient.GetItemPhotoByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Photo())
            : ItemClient.GetItemPhotoByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v2)]
    Task IItemClient.PostItemsAsync(string licenseNumber, IEnumerable<PostItemsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v2)]
    Task IItemClient.PostItemsAsync(string licenseNumber, IEnumerable<PostItemsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_items_v2)]
    Task IItemClient.PutItemsAsync(string licenseNumber, IEnumerable<PutItemsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PutItemsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_items_v2)]
    Task IItemClient.PutItemsAsync(string licenseNumber, IEnumerable<PutItemsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PutItemsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    Task IItemClient.PostItemPhotoAsync(string licenseNumber, IEnumerable<PostItemPhotoRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemPhotoAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    Task IItemClient.PostItemPhotoAsync(string licenseNumber, IEnumerable<PostItemPhotoRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemPhotoAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_items_v2_brand_id)]
    Task IItemClient.DeleteItemBrandByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemBrandByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_items_v2_brand_id)]
    Task IItemClient.DeleteItemBrandByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemBrandByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v2_brand)]
    Task IItemClient.PostItemBrandAsync(string licenseNumber, IEnumerable<PostItemBrandRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemBrandAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v2_brand)]
    Task IItemClient.PostItemBrandAsync(string licenseNumber, IEnumerable<PostItemBrandRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PostItemBrandAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_items_v2_brand)]
    Task IItemClient.PutItemBrandAsync(string licenseNumber, IEnumerable<PutItemBrandRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PutItemBrandAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_items_v2_brand)]
    Task IItemClient.PutItemBrandAsync(string licenseNumber, IEnumerable<PutItemBrandRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.PutItemBrandAsync(licenseNumber, body, cancellationToken);
}