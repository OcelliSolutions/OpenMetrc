namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class UnitOfMeasureController : UnitsOfMeasureControllerBase
{
    /// <inheritdoc cref="UnitsOfMeasureControllerBase.GetUnitOfMeasureActive" />
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<UnitOfMeasure>), StatusCodes.Status200OK)]
    public override Task GetUnitOfMeasureActive() => Task.CompletedTask;
}