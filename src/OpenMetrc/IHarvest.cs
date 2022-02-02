namespace OpenMetrc;

public interface IHarvest
{
    /// <summary>Get a specific harvest by id</summary>
    /// <param name="id">Harvest ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Harvest will be validated against the specified License Number. If not
    ///     specified, the Harvest will be validated against all of the User's current Facilities. Please note that if the
    ///     Harvest is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Harvest> GetHarvestByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific harvest by id</summary>
    /// <param name="id">Harvest ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Harvest will be validated against the specified License Number. If not
    ///     specified, the Harvest will be validated against all of the User's current Facilities. Please note that if the
    ///     Harvest is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Harvest> GetHarvestByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get harvests in an active status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of active harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get harvests in an active status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of active harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetActiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get harvests in an onhold status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of onhold harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get harvests in an onhold status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of onhold harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetOnHoldHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get harvests in an inactive status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of inactive harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetInactiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get harvests in an inactive status</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of inactive harvests.
    ///     License &lt;code&gt;CanGrowPlants&lt;/code&gt;
    /// </param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Harvest>> GetInactiveHarvestsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get harvests waste types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<HarvestWasteType>> GetHarvestWasteTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get harvests waste types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<HarvestWasteType>> GetHarvestWasteTypesAsync(CancellationToken cancellationToken);

    /// <summary>Create packages for one or more harvests</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create packages for one or more harvests</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create packages for one or more harvests for testing</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create packages for one or more harvests for testing</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageTestingAsync(string licenseNumber, IEnumerable<CreateHarvestPackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Move a harvest to a new room</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Move a harvest to a new room</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MoveHarvestAsync(string licenseNumber, IEnumerable<MoveHarvestRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Remove waste from a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Remove waste from a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RemoveWasteAsync(string licenseNumber, IEnumerable<RemoveWasteRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Rename a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Rename a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RenameHarvestAsync(string licenseNumber, IEnumerable<RenameHarvestRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Finish a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Finish a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task FinishHarvestAsync(string licenseNumber, IEnumerable<FinishHarvestRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Unfinish a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Unfinish a harvest</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UnfinishHarvestAsync(string licenseNumber, IEnumerable<UnfinishHarvestRequest> body,
        CancellationToken cancellationToken);
}