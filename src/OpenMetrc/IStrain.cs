namespace OpenMetrc;

public interface IStrain
{
    /// <summary>Get a specific strain by id</summary>
    /// <param name="id">Strain ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Strain will be validated against the specified License Number. If not
    ///     specified, the Strain will be validated against all of the User's current Facilities. Please note that if the
    ///     Strain is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Strain> GetStrainByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific strain by id</summary>
    /// <param name="id">Strain ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Strain will be validated against the specified License Number. If not
    ///     specified, the Strain will be validated against all of the User's current Facilities. Please note that if the
    ///     Strain is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Strain> GetStrainByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Delete an strain</summary>
    /// <param name="id">Strain ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteStrainAsync(string licenseNumber, long id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete an strain</summary>
    /// <param name="id">Strain ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteStrainAsync(string licenseNumber, long id, CancellationToken cancellationToken);

    /// <summary>Get active strains</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active strains.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Strain>> GetActiveStrainsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active strains</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active strains.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Strain>> GetActiveStrainsAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Create strains</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create strains</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateStrainAsync(string licenseNumber, IEnumerable<CreateStrainRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update strains</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update strains</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateStrainAsync(string licenseNumber, IEnumerable<UpdateStrainRequest> body,
        CancellationToken cancellationToken);
}