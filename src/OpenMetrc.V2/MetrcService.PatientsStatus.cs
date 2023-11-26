namespace OpenMetrc.V2;

public partial class MetrcService : IPatientStatusClient
{
    [MapsToApi(MetrcEndpoint.get_patients_v2_statuses_patientLicenseNumber)]
    Task<ICollection<PatientStatus>?> IPatientStatusClient.GetPatientStatusesAsync(string patientLicenseNumber, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientStatus>?>(new List<PatientStatus>())
            : PatientStatusClient.GetPatientStatusesAsync(patientLicenseNumber, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v2_statuses_patientLicenseNumber)]
    Task<ICollection<PatientStatus>?> IPatientStatusClient.GetPatientStatusesAsync(string patientLicenseNumber, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientStatus>?>(new List<PatientStatus>())
            : PatientStatusClient.GetPatientStatusesAsync(patientLicenseNumber, licenseNumber, cancellationToken);
}