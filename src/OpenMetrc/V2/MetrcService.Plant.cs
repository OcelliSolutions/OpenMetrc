namespace OpenMetrc.V2;

public partial class MetrcService : IPlantClient
{
    [MapsToApi(MetrcEndpoint.get_plants_v2_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v2_id)]
    Task<Plant> IPlantClient.GetPlantByIdAsync(long id, string? licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v2_label)]
    Task<Plant> IPlantClient.GetPlantByLabelAsync(string label, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Plant())
            : PlantClient.GetPlantByLabelAsync(label, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_vegetative)]
    Task<PlantMetrcWrapper> IPlantClient.GetVegetativePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v2_vegetative)]
    Task<PlantMetrcWrapper> IPlantClient.GetVegetativePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetVegetativePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_flowering)]
    Task<PlantMetrcWrapper> IPlantClient.GetFloweringPlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v2_flowering)]
    Task<PlantMetrcWrapper> IPlantClient.GetFloweringPlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetFloweringPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_onhold)]
    Task<PlantMetrcWrapper> IPlantClient.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v2_onhold)]
    Task<PlantMetrcWrapper> IPlantClient.GetOnHoldPlantsAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetOnHoldPlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_inactive)]
    Task<PlantMetrcWrapper> IPlantClient.GetInactivePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v2_inactive)]
    Task<PlantMetrcWrapper> IPlantClient.GetInactivePlantsAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantMetrcWrapper())
            : PlantClient.GetInactivePlantsAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives)]
    Task<PlantAdditiveMetrcWrapper> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantAdditiveMetrcWrapper())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives)]
    Task<PlantAdditiveMetrcWrapper> IPlantClient.GetPlantAdditivesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantAdditiveMetrcWrapper())
            : PlantClient.GetPlantAdditivesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives)]
    Task IPlantClient.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives)]
    Task IPlantClient.AddAdditiveToPlantAsync(string licenseNumber, IEnumerable<AddAdditiveToPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_growthphases)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v2_growthphases)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantGrowthPhasesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantGrowthPhasesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_tag)]
    Task IPlantClient.TagPlantsAsync(string licenseNumber, IEnumerable<TagPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.TagPlantsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_tag)]
    Task IPlantClient.TagPlantsAsync(string licenseNumber, IEnumerable<TagPlantRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.TagPlantsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_strain)]
    Task IPlantClient.UpdatePlantsStrainsAsync(string licenseNumber, IEnumerable<UpdatePlantStrainRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.UpdatePlantsStrainsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_strain)]
    Task IPlantClient.UpdatePlantsStrainsAsync(string licenseNumber, IEnumerable<UpdatePlantStrainRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.UpdatePlantsStrainsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives_types)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantAdditivesTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantAdditivesTypesAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v2_additives_types)]
    Task<StringMetrcWrapper> IPlantClient.GetPlantAdditivesTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : PlantClient.GetPlantAdditivesTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_methods_all)]
    Task<PlantWasteMethodMetrcWrapper> IPlantClient.GetPlantWasteMethodsAllAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteMethodMetrcWrapper())
            : PlantClient.GetPlantWasteMethodsAllAsync();

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_methods_all)]
    Task<PlantWasteMethodMetrcWrapper> IPlantClient.GetPlantWasteMethodsAllAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteMethodMetrcWrapper())
            : PlantClient.GetPlantWasteMethodsAllAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_split)]
    Task IPlantClient.SplitPlantAsync(string licenseNumber, IEnumerable<SplitPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.SplitPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_split)]
    Task IPlantClient.SplitPlantAsync(string licenseNumber, IEnumerable<SplitPlantRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.SplitPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_reasons)]
    Task<PlantWasteReasonMetrcWrapper> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteReasonMetrcWrapper())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_plants_v2_waste_reasons)]
    Task<PlantWasteReasonMetrcWrapper> IPlantClient.GetPlantWasteReasonsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PlantWasteReasonMetrcWrapper())
            : PlantClient.GetPlantWasteReasonsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_location)]
    Task IPlantClient.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MovePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_location)]
    Task IPlantClient.MovePlantAsync(string licenseNumber, IEnumerable<MovePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MovePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_growthphase)]
    Task IPlantClient.ChangePlantGrowthPhaseAsync(string licenseNumber,
        IEnumerable<ChangePlantGrowthPhaseRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ChangePlantGrowthPhaseAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_growthphase)]
    Task IPlantClient.ChangePlantGrowthPhaseAsync(string licenseNumber,
        IEnumerable<ChangePlantGrowthPhaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ChangePlantGrowthPhaseAsync(licenseNumber, body, cancellationToken);
    
    [MapsToApi(MetrcEndpoint.delete_plants_v2)]
    Task IPlantClient.DeletePlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.delete_plants_v2)]
    Task IPlantClient.DeletePlantAsync(string licenseNumber, IEnumerable<DestroyPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.DeletePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_waste)]
    Task IPlantClient.CreatePlantWasteAsync(string licenseNumber, IEnumerable<CreatePlantWasteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantWasteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_waste)]
    Task IPlantClient.CreatePlantWasteAsync(string licenseNumber, IEnumerable<CreatePlantWasteRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantWasteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives_bylocation)]
    Task IPlantClient.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_additives_bylocation)]
    Task IPlantClient.AddAdditiveToPlantByLocationAsync(string licenseNumber,
        IEnumerable<AddAdditiveToPlantByLocationRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.AddAdditiveToPlantByLocationAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantings)]
    Task IPlantClient.
        CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantingOfPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantings)]
    Task IPlantClient.CreatePlantingOfPlantAsync(string licenseNumber, IEnumerable<CreatePlantingOfPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantingOfPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantbatch_packages)]
    Task IPlantClient.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_plantbatch_packages)]
    Task IPlantClient.CreatePlantBatchFromPlantPackageAsync(string licenseNumber,
        IEnumerable<CreatePlantBatchFromPlantPackageRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.CreatePlantBatchFromPlantPackageAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_harvest)]
    Task IPlantClient.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.HarvestPlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_harvest)]
    Task IPlantClient.HarvestPlantAsync(string licenseNumber, IEnumerable<HarvestPlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.HarvestPlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_plants_v2_merge)]
    Task IPlantClient.MergePlantAsync(string licenseNumber, IEnumerable<MergePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MergePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_plants_v2_merge)]
    Task IPlantClient.MergePlantAsync(string licenseNumber, IEnumerable<MergePlantRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.MergePlantAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_plants_v2_manicure)]
    Task IPlantClient.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ManicurePlantAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_plants_v2_manicure)]
    Task IPlantClient.ManicurePlantAsync(string licenseNumber, IEnumerable<ManicurePlantRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PlantClient.ManicurePlantAsync(licenseNumber, body, cancellationToken);
}