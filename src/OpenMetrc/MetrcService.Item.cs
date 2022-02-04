namespace OpenMetrc;

public partial class MetrcService : IItem
{
    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    Task<Item> IItem.GetItemByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : UserMetrcClient.GetItemByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_id)]
    Task<Item> IItem.GetItemByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Item())
            : UserMetrcClient.GetItemByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    Task IItem.DeleteItemAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteItemAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_items_v1_id)]
    Task IItem.DeleteItemAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteItemAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    Task<ICollection<Item>> IItem.GetActiveItemsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>>(new List<Item>())
            : UserMetrcClient.GetActiveItemsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_active)]
    Task<ICollection<Item>> IItem.GetActiveItemsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Item>>(new List<Item>())
            : UserMetrcClient.GetActiveItemsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    Task<ICollection<ItemCategory>> IItem.GetItemCategoriesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemCategory>>(new List<ItemCategory>())
            : UserMetrcClient.GetItemCategoriesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_categories)]
    Task<ICollection<ItemCategory>> IItem.GetItemCategoriesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemCategory>>(new List<ItemCategory>())
            : UserMetrcClient.GetItemCategoriesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    Task<ICollection<ItemBrand>> IItem.GetItemBrandsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemBrand>>(new List<ItemBrand>())
            : UserMetrcClient.GetItemBrandsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_items_v1_brands)]
    Task<ICollection<ItemBrand>> IItem.GetItemBrandsAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<ItemBrand>>(new List<ItemBrand>())
            : UserMetrcClient.GetItemBrandsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    Task IItem.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v1_create)]
    Task IItem.CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateItemAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    Task IItem.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateItemAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_items_v1_update)]
    Task IItem.UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateItemAsync(licenseNumber, body, cancellationToken);
}