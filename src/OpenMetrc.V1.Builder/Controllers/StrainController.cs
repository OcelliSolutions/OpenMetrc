namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class StrainController : StrainsControllerBase
{
    /// <inheritdoc cref="StrainsControllerBase.GetStrainById" />
    [MapsToApi(MetrcEndpoint.get_strains_v1_id)]
    [ProducesResponseType(typeof(Strain), StatusCodes.Status200OK)]
    public override Task GetStrainById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.GetStrainActive" />
    [MapsToApi(MetrcEndpoint.get_strains_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Strain>), StatusCodes.Status200OK)]
    public override Task GetStrainActive(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.PostStrainCreate" />
    [MapsToApi(MetrcEndpoint.post_strains_v1_create)]
    public override Task PostStrainCreate(
        [Required] List<PostStrainCreateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.PostStrainUpdate" />
    [MapsToApi(MetrcEndpoint.post_strains_v1_update)]
    public override Task PostStrainUpdate(
        [Required] List<PostStrainUpdateRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.DeleteStrainById" />
    [MapsToApi(MetrcEndpoint.delete_strains_v1_id)]
    public override Task DeleteStrainById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}