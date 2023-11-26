namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class WasteMethodController : WasteMethodsControllerBase
{
    /// <inheritdoc cref="WasteMethodsControllerBase.GetWasteMethods" />
    [MapsToApi(MetrcEndpoint.get_wastemethods_v2)]
    [ProducesResponseType(typeof(ICollection<WasteMethod>), StatusCodes.Status200OK)]
    public override Task GetWasteMethods() => throw new NotImplementedException();
}