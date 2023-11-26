namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class FacilityController : FacilitiesControllerBase
{
    /// <inheritdoc cref="FacilitiesControllerBase.GetFacilities" />
    [MapsToApi(MetrcEndpoint.get_facilities_v2)]
    [ProducesResponseType(typeof(ICollection<Facility>), StatusCodes.Status200OK)]
    public override Task GetFacilities() => Task.CompletedTask;
}