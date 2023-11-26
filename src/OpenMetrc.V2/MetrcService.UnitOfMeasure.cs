namespace OpenMetrc.V2;

public partial class MetrcService : IUnitOfMeasureClient
{
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_active)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetUnitOfMeasureActiveAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetUnitOfMeasureActiveAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_inactive)]
    Task<UnitOfMeasureMetrcWrapper> IUnitOfMeasureClient.GetUnitOfMeasureInactiveAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new UnitOfMeasureMetrcWrapper())
            : UnitOfMeasureClient.GetUnitOfMeasureInactiveAsync(cancellationToken);
}