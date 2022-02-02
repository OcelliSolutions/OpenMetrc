namespace OpenMetrc;

public interface ILocation
{
    /// <summary>Get a specific location by id</summary>
    /// <param name="id">Location ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Location will be validated against the specified License Number. If not
    ///     specified, the Location will be validated against all of the User's current Facilities. Please note that if the
    ///     Location is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Location> GetLocationByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific location by id</summary>
    /// <param name="id">Location ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Location will be validated against the specified License Number. If not
    ///     specified, the Location will be validated against all of the User's current Facilities. Please note that if the
    ///     Location is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Location> GetLocationByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Delete an location</summary>
    /// <param name="id">Location ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteLocationAsync(string licenseNumber, long id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete an location</summary>
    /// <param name="id">Location ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteLocationAsync(string licenseNumber, long id, CancellationToken cancellationToken);

    /// <summary>Get active locations</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active locations.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Location>> GetActiveLocationsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active locations</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active locations.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Location>> GetActiveLocationsAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get location types</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active location types.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LocationType>> GetLocationTypesAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get location types</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active location types.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LocationType>> GetLocationTypesAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Create locations</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create locations</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateLocationAsync(string licenseNumber, IEnumerable<CreateLocationRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update locations</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update locations</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateLocationAsync(string licenseNumber, IEnumerable<UpdateLocationRequest> body,
        CancellationToken cancellationToken);
}