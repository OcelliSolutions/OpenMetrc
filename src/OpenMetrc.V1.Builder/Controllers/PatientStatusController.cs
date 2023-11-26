namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class PatientStatusController : PatientsStatusControllerBase
{
    /// <inheritdoc cref="PatientsStatusControllerBase.GetPatientStatuses" />
    [MapsToApi(MetrcEndpoint.get_patients_v1_statuses_patientLicenseNumber)]
    [ProducesResponseType(typeof(IEnumerable<PatientStatus>), StatusCodes.Status200OK)]
    public override Task GetPatientStatuses(
        [Required] string patientLicenseNumber,
        [Required] string licenseNumber) => Task.CompletedTask;
}