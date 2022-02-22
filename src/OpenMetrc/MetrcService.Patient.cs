namespace OpenMetrc;

public partial class MetrcService : IPatientClient
{
    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    Task<Patient> IPatientClient.GetPatientByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : PatientClient.GetPatientByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    Task<Patient> IPatientClient.GetPatientByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : PatientClient.GetPatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    Task IPatientClient.DeletePatientAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.DeletePatientAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    Task IPatientClient.DeletePatientAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.DeletePatientAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>?> IPatientClient.GetActivePatientsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>?>(new List<Patient>())
            : PatientClient.GetActivePatientsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>?> IPatientClient.GetActivePatientsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>?>(new List<Patient>())
            : PatientClient.GetActivePatientsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v1_statuses_patientLicenseNumber)]
    Task<ICollection<Patient>?> IPatientClient.
        GetPatientStatusAsync(string patientLicenseNumber, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>?>(new List<Patient>())
            : PatientClient.GetPatientStatusAsync(patientLicenseNumber, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_statuses_patientLicenseNumber)]
    Task<ICollection<Patient>?> IPatientClient.GetPatientStatusAsync(string patientLicenseNumber, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>?>(new List<Patient>())
            : PatientClient.GetPatientStatusAsync(patientLicenseNumber, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    Task IPatientClient.CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.CreatePatientAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    Task IPatientClient.CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.CreatePatientAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    Task IPatientClient.UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.UpdatePatientAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    Task IPatientClient.UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientClient.UpdatePatientAsync(licenseNumber, body, cancellationToken);
}