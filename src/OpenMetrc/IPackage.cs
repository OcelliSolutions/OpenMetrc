namespace OpenMetrc;

public interface IPackage
{
    /// <summary>Get a specific package by id</summary>
    /// <param name="id">Package ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Package will be validated against the specified License Number. If not
    ///     specified, the Package will be validated against all of the User's current Facilities. Please note that if the
    ///     Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Package> GetPackageByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific package by id</summary>
    /// <param name="id">Package ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Package will be validated against the specified License Number. If not
    ///     specified, the Package will be validated against all of the User's current Facilities. Please note that if the
    ///     Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Package> GetPackageByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get a specific package by label</summary>
    /// <param name="label">Package Label</param>
    /// <param name="licenseNumber">
    ///     If specified, the Package will be validated against the specified License Number. If not
    ///     specified, the Package will be validated against all of the User's current Facilities. Please note that if the
    ///     Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Package> GetPackageByLabelAsync(string label, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific package by label</summary>
    /// <param name="label">Package Label</param>
    /// <param name="licenseNumber">
    ///     If specified, the Package will be validated against the specified License Number. If not
    ///     specified, the Package will be validated against all of the User's current Facilities. Please note that if the
    ///     Package is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Package> GetPackageByLabelAsync(string label, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get packages in an active status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get packages in an active status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetActivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get packages in an onhold status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of onhold packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get packages in an onhold status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of onhold packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetOnHoldPackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get packages in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetInactivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get packages in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive packages.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Package>> GetInactivePackagesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get package types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPackageTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get package types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPackageTypesAsync(CancellationToken cancellationToken);

    /// <summary>Get package adjust reasons</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PackageAdjustReason>> GetPackageAdjustReasonsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get package adjust reasons</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PackageAdjustReason>> GetPackageAdjustReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken);

    /// <summary>Create packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create testing packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create testing packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateTestingPackageAsync(string licenseNumber, IEnumerable<CreatePackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create package plantings</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create package plantings</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackagePlantingAsync(string licenseNumber, IEnumerable<CreatePackagePlantingRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Change the package item</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Change the package item</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageItemAsync(string licenseNumber, IEnumerable<ChangePackageItemRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update a package note</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update a package note</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageNoteAsync(string licenseNumber, IEnumerable<ChangePackageNoteRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Change a package location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Change a package location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePackageLocationAsync(string licenseNumber, IEnumerable<ChangePackageLocationRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Adjust packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Adjust packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AdjustPackageAsync(string licenseNumber, IEnumerable<AdjustPackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Finish packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Finish packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task FinishPackageAsync(string licenseNumber, IEnumerable<FinishPackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Unfinish packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Unfinish packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UnfinishPackageAsync(string licenseNumber, IEnumerable<UnfinishPackageRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Remediate packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Remediate packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RemediatePackageAsync(string licenseNumber, IEnumerable<RemediatePackageRequest> body,
        CancellationToken cancellationToken);
}