namespace OpenMetrc;

public interface IItem
{
    /// <summary>Get a specific item by id</summary>
    /// <param name="id">Item ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Item will be validated against the specified License Number. If not
    ///     specified, the Item will be validated against all of the User's current Facilities. Please note that if the Item is
    ///     not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Item> GetItemByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific item by id</summary>
    /// <param name="id">Item ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Item will be validated against the specified License Number. If not
    ///     specified, the Item will be validated against all of the User's current Facilities. Please note that if the Item is
    ///     not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Item> GetItemByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Delete an item</summary>
    /// <param name="id">Item ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteItemAsync(string licenseNumber, long id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete an item</summary>
    /// <param name="id">Item ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteItemAsync(string licenseNumber, long id, CancellationToken cancellationToken);

    /// <summary>Get active items</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active items.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Item>> GetActiveItemsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active items</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active items.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Item>> GetActiveItemsAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get item categories</summary>
    /// <param name="licenseNumber">
    ///     If specified, the Categories will be retrived for the specified License Number. If not
    ///     specified, the all Item Categories will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<ItemCategory>> GetItemCategoriesAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get item categories</summary>
    /// <param name="licenseNumber">
    ///     If specified, the Categories will be retrived for the specified License Number. If not
    ///     specified, the all Item Categories will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<ItemCategory>> GetItemCategoriesAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get item brands</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active item brands.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<ItemBrand>> GetItemBrandsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get item brands</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active item brands.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<ItemBrand>> GetItemBrandsAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Create items</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create items</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update items</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update items</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateItemAsync(string licenseNumber, IEnumerable<CreateItemRequest> body,
        CancellationToken cancellationToken);
}