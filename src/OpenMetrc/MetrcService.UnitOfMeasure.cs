namespace OpenMetrc;

public partial class MetrcService : IUnitOfMeasureClient
{
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    Task<ICollection<UnitOfMeasure>> IUnitOfMeasureClient.GetUnitsOfMeasureAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<UnitOfMeasure>>(new List<UnitOfMeasure>())
            : UnitOfMeasureClient.GetUnitsOfMeasureAsync();

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    Task<ICollection<UnitOfMeasure>> IUnitOfMeasureClient.GetUnitsOfMeasureAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<UnitOfMeasure>>(new List<UnitOfMeasure>())
            : UnitOfMeasureClient.GetUnitsOfMeasureAsync(cancellationToken);
}