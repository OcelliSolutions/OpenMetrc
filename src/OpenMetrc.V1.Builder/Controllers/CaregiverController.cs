namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class CaregiverController : CaregiversStatusControllerBase
{
    /// <inheritdoc cref="CaregiversStatusControllerBase.GetCaregiverStatus" />
    [MapsToApi(MetrcEndpoint.get_caregivers_v1_status_caregiverLicenseNumber)]
    [ProducesResponseType(typeof(CaregiverStatus), StatusCodes.Status200OK)]
    public override Task
        GetCaregiverStatus([Required] string caregiverLicenseNumber, [Required] string licenseNumber) =>
        Task.CompletedTask;
}