namespace OpenMetrc;

public partial class MetrcService : IPlant
{
    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    Task<Plant> IPlant.GetPlantByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : UserMetrcClient.GetPlantByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_id)]
    Task<Plant> IPlant.GetPlantByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : UserMetrcClient.GetPlantByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    Task<Plant> IPlant.GetPlantByLabelAsync(string label, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : UserMetrcClient.GetPlantByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_label)]
    Task<Plant> IPlant.GetPlantByLabelAsync(string label, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : UserMetrcClient.GetPlantByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    Task<ICollection<Plant>> IPlant.GetVegetativePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_vegetative)]
    Task<ICollection<Plant>> IPlant.GetVegetativePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    Task<ICollection<Plant>> IPlant.GetFloweringPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_flowering)]
    Task<ICollection<Plant>> IPlant.GetFloweringPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    Task<ICollection<Plant>> IPlant.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_onhold)]
    Task<ICollection<Plant>> IPlant.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    Task<ICollection<Plant>> IPlant.GetInactivePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_inactive)]
    Task<ICollection<Plant>> IPlant.GetInactivePlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Plant>>(new List<Plant>())
            : UserMetrcClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    Task<ICollection<PlantAdditive>> IPlant.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantAdditive>>(new List<PlantAdditive>())
            : UserMetrcClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives)]
    Task<ICollection<PlantAdditive>> IPlant.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantAdditive>>(new List<PlantAdditive>())
            : UserMetrcClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    Task IPlant.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives)]
    Task IPlant.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    Task<ICollection<string>> IPlant.GetPlantGrowthPhasesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantGrowthPhasesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_growthphases)]
    Task<ICollection<string>> IPlant.GetPlantGrowthPhasesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantGrowthPhasesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    Task<ICollection<string>> IPlant.GetPlantAdditivesTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantAdditivesTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v1_additives_types)]
    Task<ICollection<string>> IPlant.GetPlantAdditivesTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetPlantAdditivesTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods)]
    Task<ICollection<PlantWasteMethod>> IPlant.GetPlantWasteMethodsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteMethod>>(new List<PlantWasteMethod>())
            : UserMetrcClient.GetPlantWasteMethodsAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_methods)]
    Task<ICollection<PlantWasteMethod>> IPlant.GetPlantWasteMethodsAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteMethod>>(new List<PlantWasteMethod>())
            : UserMetrcClient.GetPlantWasteMethodsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    Task<ICollection<PlantWasteReason>> IPlant.GetPlantWasteReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteReason>>(new List<PlantWasteReason>())
            : UserMetrcClient.GetPlantWasteReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v1_waste_reasons)]
    Task<ICollection<PlantWasteReason>> IPlant.GetPlantWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PlantWasteReason>>(new List<PlantWasteReason>())
            : UserMetrcClient.GetPlantWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    Task IPlant.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MovePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_moveplants)]
    Task IPlant.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.MovePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    Task IPlant.ChangePlantGrowthPhaseAsync(string licenseNumber, IEnumerable<ChangePlantGrowthPhaseRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePlantGrowthPhaseAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_changegrowthphases)]
    Task IPlant.ChangePlantGrowthPhaseAsync(string licenseNumber, IEnumerable<ChangePlantGrowthPhaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ChangePlantGrowthPhaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_destroyplants)]
    Task IPlant.DestroyPlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DestroyPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_destroyplants)]
    Task IPlant.DestroyPlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DestroyPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    Task IPlant.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_additives_bylocation)]
    Task IPlant.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    Task IPlant.CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantingOfPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantings)]
    Task IPlant.CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantingOfPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    Task IPlant.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_create_plantbatch_packages)]
    Task IPlant.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    Task IPlant.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.HarvestPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_harvestplants)]
    Task IPlant.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.HarvestPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    Task IPlant.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ManicurePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v1_manicureplants)]
    Task IPlant.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.ManicurePlantAsync(licenseNumber, body, cancellationToken);
}