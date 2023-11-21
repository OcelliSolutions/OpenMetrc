namespace OpenMetrc.V2;

public partial class MetrcService : IUnitOfMeasureClient
{
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_active)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetActiveUnitsOfMeasureAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetActiveUnitsOfMeasureAsync();

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_active)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetActiveUnitsOfMeasureAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetActiveUnitsOfMeasureAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_inactive)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetInactiveUnitsOfMeasureAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetInactiveUnitsOfMeasureAsync();

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_inactive)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetInactiveUnitsOfMeasureAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetInactiveUnitsOfMeasureAsync(cancellationToken);
}