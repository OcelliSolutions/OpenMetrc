namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class UnitOfMeasureController : UnitsOfMeasureControllerBase
{
    /// <inheritdoc cref="UnitsOfMeasureControllerBase.GetUnitOfMeasureActive" />
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<UnitOfMeasure>), StatusCodes.Status200OK)]
    public override Task GetUnitOfMeasureActive() => Task.CompletedTask;

    /// <inheritdoc cref="UnitsOfMeasureControllerBase.GetUnitOfMeasureInactive" />
    [MapsToApi(MetrcEndpoint.get_unitsofmeasure_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<UnitOfMeasure>), StatusCodes.Status200OK)]
    public override Task GetUnitOfMeasureInactive() => Task.CompletedTask;
}