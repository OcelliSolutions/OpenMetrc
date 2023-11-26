namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class TagController : TagsControllerBase
{
    /// <inheritdoc cref="TagsControllerBase.GetTagPackageAvailable" />
    [MapsToApi(MetrcEndpoint.get_tags_v2_package_available)]
    [ProducesResponseType(typeof(ICollection<Tag>), StatusCodes.Status200OK)]
    public override Task GetTagPackageAvailable(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TagsControllerBase.GetTagPlantAvailable" />
    [MapsToApi(MetrcEndpoint.get_tags_v2_plant_available)]
    [ProducesResponseType(typeof(ICollection<Tag>), StatusCodes.Status200OK)]
    public override Task GetTagPlantAvailable(
        [Required] string licenseNumber) => Task.CompletedTask;
}