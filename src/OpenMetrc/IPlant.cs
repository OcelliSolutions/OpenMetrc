namespace OpenMetrc;

public interface IPlant
{
    /// <summary>Get a specific plant by id</summary>
    /// <param name="id">Plant ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant will be validated against the specified License Number. If not
    ///     specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant
    ///     is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Plant> GetPlantByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific plant by id</summary>
    /// <param name="id">Plant ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant will be validated against the specified License Number. If not
    ///     specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant
    ///     is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Plant> GetPlantByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get a specific plant by label</summary>
    /// <param name="label">Plant Label</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant will be validated against the specified License Number. If not
    ///     specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant
    ///     is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Plant> GetPlantByLabelAsync(string label, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific plant by label</summary>
    /// <param name="label">Plant Label</param>
    /// <param name="licenseNumber">
    ///     If specified, the Plant will be validated against the specified License Number. If not
    ///     specified, the Plant will be validated against all of the User's current Facilities. Please note that if the Plant
    ///     is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Plant> GetPlantByLabelAsync(string label, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get plants in an vegetating status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of vegetating plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetVegetativePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plants in an vegetating status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of vegetating plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetVegetativePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plants in an flowering status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of flowering plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetFloweringPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plants in an flowering status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of flowering plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetFloweringPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plants in an onhold status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of onhold plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plants in an onhold status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of onhold plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plants in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetInactivePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plants in an inactive status</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of inactive plants.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Plant>> GetInactivePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get plant additives</summary>
    /// <param name="licenseNumber">The license number of the facility for which to record plant additives.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantAdditive>> GetPlantAdditivesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant additives</summary>
    /// <param name="licenseNumber">The license number of the facility for which to record plant additives.</param>
    /// <param name="lastModifiedStart">The last modified start timestamp</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantAdditive>> GetPlantAdditivesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Add additives to a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <param name="licenseNumber">The license number of the facility for plant growth phases</param>
    /// <summary>Add additives to a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Get plant growth phases</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantGrowthPhasesAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant growth phases</summary>
    /// <param name="licenseNumber">The license number of the facility for plant growth phases</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantGrowthPhasesAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get plant additive types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantAdditivesTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant additive types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetPlantAdditivesTypesAsync(CancellationToken cancellationToken);

    /// <summary>Get plant waste methods</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantWasteMethod>> GetPlantWasteMethodsAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant waste methods</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantWasteMethod>> GetPlantWasteMethodsAsync(CancellationToken cancellationToken);

    /// <summary>Get plant waste reasons</summary>
    /// <returns>Success</returns>
    /// <param name="licenseNumber">The license number of the facility for plant waste reasons</param>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantWasteReason>> GetPlantWasteReasonsAsync(string licenseNumber);

    /// <param name="licenseNumber">The license number of the facility for plant waste reasons</param>
    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get plant waste reasons</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<PlantWasteReason>> GetPlantWasteReasonsAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Move a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Move a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body, CancellationToken cancellationToken);

    /// <summary>Change a plant's growth phase</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePlantGrowthPhaseAsync(string licenseNumber, IEnumerable<ChangePlantGrowthPhaseRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Change a plant's growth phase</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ChangePlantGrowthPhaseAsync(string licenseNumber, IEnumerable<ChangePlantGrowthPhaseRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Destroy a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DestroyPlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Destroy a plant</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DestroyPlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Add additives to plants by location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantByLocationAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantByLocationRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Add additives to plants by location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task AddAdditiveToPlantByLocationAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantByLocationRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Add additives to plants by location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Add additives to plants by location</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create plant batch from plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create plant batch from plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body, CancellationToken cancellationToken);

    /// <summary>Harvest plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Harvest plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Manicure plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Manicure plants</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body,
        CancellationToken cancellationToken);
}