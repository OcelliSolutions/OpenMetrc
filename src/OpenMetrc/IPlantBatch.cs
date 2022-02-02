namespace OpenMetrc;

public interface IPlantBatch
{
    /// <summary>Get a specific plant batch by id</summary>
    /// <param name="id">Plant Batch ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant Batch will be validated against the specified License Number. If
    ///     not specified, the Plant Batch will be validated against all of the User's current Facilities. Please note that if
    ///     the Plant Batch is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<PlantBatch> GetPlantBatchByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific plant batch by id</summary>
    /// <param name="id">Plant Batch ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant Batch will be validated against the specified License Number. If
    ///     not specified, the Plant Batch will be validated against all of the User's current Facilities. Please note that if
    ///     the Plant Batch is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<PlantBatch> GetPlantBatchByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get plant batches in an active status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active plant batches.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantBatch>> GetActivePlantBatchesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant batches in an active status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active plant batches.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantBatch>> GetActivePlantBatchesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plant batches in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive plant batches.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantBatch>> GetInactivePlantBatchesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant batches in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive plant batches.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantBatch>> GetInactivePlantBatchesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plant batch types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantBatchTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant batch types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantBatchTypesAsync(CancellationToken cancellationToken);

    /// <summary>Create plant batch plantings</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchPlantingsAsync(string licenseNumber, IEnumerable<CreatePlantBatchPlantingRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create plant batch plantings</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchPlantingsAsync(string licenseNumber, IEnumerable<CreatePlantBatchPlantingRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create plant batch packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create plant batch packages</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchPackagesAsync(string licenseNumber, bool? isFromMotherPlant,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken);

    /// <summary>Split a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Split a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task SplitPlantBatchAsync(string licenseNumber, IEnumerable<SplitPlantBatchRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create packages from a mother plant for a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create packages from a mother plant for a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePackageFromPlantBatchMotherPlantAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchPackageRequest> body, CancellationToken cancellationToken);

    /// <summary>Change the growth phase for a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Change the growth phase for a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangeGrowthPhaseForPlantBatchAsync(string licenseNumber,
        IEnumerable<ChangeGrowthPhaseForPlantBatchRequest> body, CancellationToken cancellationToken);

    /// <summary>Move a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Move a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MovePlantBatchAsync(string licenseNumber, IEnumerable<MovePlantBatchRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Add plant additives to a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantBatchAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantBatchRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Add plant additives to a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantBatchAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantBatchRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Destroy a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DestroyPlantBatchAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Destroy a plant batch</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DestroyPlantBatchAsync(string licenseNumber, IEnumerable<DestroyPlantBatchRequest> body,
        CancellationToken cancellationToken);
}