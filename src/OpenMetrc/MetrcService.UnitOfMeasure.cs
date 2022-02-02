namespace OpenMetrc;

public partial class MetrcService : IUnitOfMeasure
{
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    Task<ICollection<UnitOfMeasure>> IUnitOfMeasure.GetUnitsOfMeasureAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<UnitOfMeasure>>(new List<UnitOfMeasure>())
            : MetrcClient.GetUnitsOfMeasureAsync();

    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    Task<ICollection<UnitOfMeasure>> IUnitOfMeasure.GetUnitsOfMeasureAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<UnitOfMeasure>>(new List<UnitOfMeasure>())
            : MetrcClient.GetUnitsOfMeasureAsync(cancellationToken);
}