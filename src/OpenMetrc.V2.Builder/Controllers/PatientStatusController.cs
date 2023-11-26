namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientStatusController : PatientsStatusControllerBase
{
    /// <inheritdoc cref="PatientsStatusControllerBase.GetPatientStatuses" />
    [MapsToApi(MetrcEndpoint.get_patients_v2_statuses_patientLicenseNumber)]
    [ProducesResponseType(typeof(ICollection<PatientStatus>), StatusCodes.Status200OK)]
    public override Task GetPatientStatuses(
        [Required] string patientLicenseNumber,
        [Required] string licenseNumber) => Task.CompletedTask;
}