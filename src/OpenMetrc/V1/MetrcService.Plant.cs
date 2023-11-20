namespace OpenMetrc.V1;

public partial class MetrcService : IPlantClient
{
    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    Task<ICollection<Plant>?> IPlantClient.GetVegetativePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    Task<ICollection<Plant>?> IPlantClient.GetVegetativePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    Task<ICollection<Plant>?> IPlantClient.GetFloweringPlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    Task<ICollection<Plant>?> IPlantClient.GetFloweringPlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    Task<ICollection<Plant>?> IPlantClient.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    Task<ICollection<Plant>?> IPlantClient.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    Task<ICollection<Plant>?> IPlantClient.GetInactivePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    Task<ICollection<Plant>?> IPlantClient.GetInactivePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>?>(new List<Plant>())
            : PlantClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    Task<ICollection<PlantAdditive>?> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantAdditive>?>(new List<PlantAdditive>())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    Task<ICollection<PlantAdditive>?> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantAdditive>?>(new List<PlantAdditive>())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    Task IPlantClient.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    Task IPlantClient.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    Task<ICollection<string>> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    Task<ICollection<string>> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    Task<ICollection<string>> IPlantClient.GetPlantAdditivesTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantAdditivesTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    Task<ICollection<string>> IPlantClient.GetPlantAdditivesTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : PlantClient.GetPlantAdditivesTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods_all)]
    Task<ICollection<PlantWasteMethod>?> IPlantClient.GetPlantWasteMethodsAllAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteMethod>?>(new List<PlantWasteMethod>())
            : PlantClient.GetPlantWasteMethodsAllAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods_all)]
    Task<ICollection<PlantWasteMethod>?> IPlantClient.GetPlantWasteMethodsAllAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteMethod>?>(new List<PlantWasteMethod>())
            : PlantClient.GetPlantWasteMethodsAllAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    Task<ICollection<PlantWasteReason>?> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteReason>?>(new List<PlantWasteReason>())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    Task<ICollection<PlantWasteReason>?> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteReason>?>(new List<PlantWasteReason>())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    Task IPlantClient.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MovePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    Task IPlantClient.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MovePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    Task IPlantClient.ChangePlantGrowthPhaseAsync(string licenseNumber,
        IEnumerable<ChangePlantGrowthPhaseRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ChangePlantGrowthPhaseAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    Task IPlantClient.ChangePlantGrowthPhaseAsync(string licenseNumber,
        IEnumerable<ChangePlantGrowthPhaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ChangePlantGrowthPhaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_plants_v1)]
    Task IPlantClient.DeletePlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.delete_plants_v1)]
    Task IPlantClient.DeletePlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_waste)]
    Task IPlantClient.CreatePlantWasteAsync(string licenseNumber, IEnumerable<CreatePlantWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_waste)]
    Task IPlantClient.CreatePlantWasteAsync(string licenseNumber, IEnumerable<CreatePlantWasteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    Task IPlantClient.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    Task IPlantClient.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    Task IPlantClient.
        CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantingOfPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    Task IPlantClient.CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantingOfPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    Task IPlantClient.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    Task IPlantClient.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    Task IPlantClient.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.HarvestPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    Task IPlantClient.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.HarvestPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    Task IPlantClient.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ManicurePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    Task IPlantClient.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ManicurePlantAsync(licenseNumber, body, cancellationToken);
}