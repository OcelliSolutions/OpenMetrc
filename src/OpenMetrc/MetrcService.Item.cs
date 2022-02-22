namespace OpenMetrc;

public partial class MetrcService : IItemClient
{
    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    Task<Item> IItemClient.GetItemByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : ItemClient.GetItemByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    Task<Item> IItemClient.GetItemByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : ItemClient.GetItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    Task IItemClient.DeleteItemAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    Task IItemClient.DeleteItemAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.DeleteItemAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    Task<ICollection<Item>?> IItemClient.GetActiveItemsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>?>(new List<Item>())
            : ItemClient.GetActiveItemsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    Task<ICollection<Item>?> IItemClient.
        GetActiveItemsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>?>(new List<Item>())
            : ItemClient.GetActiveItemsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    Task<ICollection<ItemCategory>?> IItemClient.GetItemCategoriesAsync(string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemCategory>?>(new List<ItemCategory>())
            : ItemClient.GetItemCategoriesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    Task<ICollection<ItemCategory>?> IItemClient.GetItemCategoriesAsync(string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemCategory>?>(new List<ItemCategory>())
            : ItemClient.GetItemCategoriesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    Task<ICollection<ItemBrand>?> IItemClient.GetItemBrandsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemBrand>?>(new List<ItemBrand>())
            : ItemClient.GetItemBrandsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    Task<ICollection<ItemBrand>?> IItemClient.GetItemBrandsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemBrand>?>(new List<ItemBrand>())
            : ItemClient.GetItemBrandsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    Task IItemClient.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    Task IItemClient.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.CreateItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    Task IItemClient.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.UpdateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    Task IItemClient.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : ItemClient.UpdateItemAsync(licenseNumber, body, cancellationToken);
}