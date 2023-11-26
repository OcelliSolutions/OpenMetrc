namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class StrainController : StrainsControllerBase
{
    /// <inheritdoc cref="StrainsControllerBase.GetStrainById" />
    [MapsToApi(MetrcEndpoint.get_strains_v2_id)]
    [ProducesResponseType(typeof(Strain), StatusCodes.Status200OK)]
    public override Task GetStrainById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.GetStrainActive" />
    [MapsToApi(MetrcEndpoint.get_strains_v2_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Strain>), StatusCodes.Status200OK)]
    public override Task GetStrainActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.GetStrainInactive" />
    [MapsToApi(MetrcEndpoint.get_strains_v2_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Strain>), StatusCodes.Status200OK)]
    public override Task GetStrainInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.PostStrains" />
    [MapsToApi(MetrcEndpoint.post_strains_v2)]
    public override Task PostStrains(
        [Required] List<PostStrainsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.PutStrains" />
    [MapsToApi(MetrcEndpoint.put_strains_v2)]
    public override Task PutStrains(
        [Required] List<PutStrainsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="StrainsControllerBase.DeleteStrainById" />
    [MapsToApi(MetrcEndpoint.delete_strains_v2_id)]
    public override Task DeleteStrainById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}