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
    Task IItemClient.DeleteItemAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_items_v2_id)]
    Task IItemClient.DeleteItemAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    Task<ItemMetrcWrapper> IItemClient.GetActiveItemsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetActiveItemsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_active)]
    Task<ItemMetrcWrapper> IItemClient.
        GetActiveItemsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetActiveItemsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    Task<ItemMetrcWrapper> IItemClient.GetInactiveItemsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetInactiveItemsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_inactive)]
    Task<ItemMetrcWrapper> IItemClient.
        GetInactiveItemsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemMetrcWrapper())
            : ItemClient.GetInactiveItemsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    Task<ItemCategoryMetrcWrapper> IItemClient.GetItemCategoriesAsync(string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemCategoryMetrcWrapper())
            : ItemClient.GetItemCategoriesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_categories)]
    Task<ItemCategoryMetrcWrapper> IItemClient.GetItemCategoriesAsync(string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemCategoryMetrcWrapper())
            : ItemClient.GetItemCategoriesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    Task<ItemBrandMetrcWrapper> IItemClient.GetItemBrandsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemBrandMetrcWrapper())
            : ItemClient.GetItemBrandsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_brands)]
    Task<ItemBrandMetrcWrapper> IItemClient.GetItemBrandsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new ItemBrandMetrcWrapper())
            : ItemClient.GetItemBrandsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    Task<Photo> IItemClient.GetItemPhotoAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Photo())
            : ItemClient.GetItemPhotoAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v2_photo_id)]
    Task<Photo> IItemClient.GetItemPhotoAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Photo())
            : ItemClient.GetItemPhotoAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v2)]
    Task IItemClient.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v2)]
    Task IItemClient.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreateItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_items_v2)]
    Task IItemClient.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.UpdateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_items_v2)]
    Task IItemClient.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.UpdateItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    Task IItemClient.CreatePhotoAsync(string licenseNumber, IEnumerable<CreatePhotoRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreatePhotoAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v2_photo)]
    Task IItemClient.CreatePhotoAsync(string licenseNumber, IEnumerable<CreatePhotoRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreatePhotoAsync(licenseNumber, body, cancellationToken);

    public Task DeleteItemBrandAsync(string licenseNumber, long id) => throw new NotImplementedException();

    public Task DeleteItemBrandAsync(string licenseNumber, long id, CancellationToken cancellationToken) => throw new NotImplementedException();
    Task IItemClient.CreateBrandAsync(string licenseNumber, IEnumerable<CreateBrandRequest> body) => throw new NotImplementedException();

    Task IItemClient.CreateBrandAsync(string licenseNumber, IEnumerable<CreateBrandRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();

    Task IItemClient.UpdateBrandAsync(string licenseNumber, IEnumerable<UpdateBrandRequest> body) => throw new NotImplementedException();

    Task IItemClient.UpdateBrandAsync(string licenseNumber, IEnumerable<UpdateBrandRequest> body, CancellationToken cancellationToken) => throw new NotImplementedException();
}