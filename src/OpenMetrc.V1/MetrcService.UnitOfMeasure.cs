namespace OpenMetrc.V1;

public partial class MetrcService : IUnitOfMeasureClient
{
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    Task<ICollection<UnitOfMeasure>?> IUnitOfMeasureClient.
        GetUnitOfMeasureActiveAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<UnitOfMeasure>?>(new List<UnitOfMeasure>())
            : UnitOfMeasureClient.GetUnitOfMeasureActiveAsync(cancellationToken);
}