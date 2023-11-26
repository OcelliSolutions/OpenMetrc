namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class FacilityController : FacilitiesControllerBase
{
    /// <inheritdoc cref="FacilitiesControllerBase.GetFacilities" />
    [MapsToApi(MetrcEndpoint.get_facilities_v1)]
    [ProducesResponseType(typeof(IEnumerable<Facility>), StatusCodes.Status200OK)]
    public override Task GetFacilities() => Task.CompletedTask;
}