namespace OpenMetrc;

public partial class MetrcService : IPatient
{
    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    Task<Patient> IPatient.GetPatientByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : MetrcClient.GetPatientByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_id)]
    Task<Patient> IPatient.GetPatientByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Patient())
            : MetrcClient.GetPatientByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    Task IPatient.DeletePatientAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeletePatientAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_patients_v1_id)]
    Task IPatient.DeletePatientAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeletePatientAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>> IPatient.GetActivePatientsAllAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>>(new List<Patient>())
            : MetrcClient.GetActivePatientsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>> IPatient.GetActivePatientsAllAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>>(new List<Patient>())
            : MetrcClient.GetActivePatientsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>> IPatient.GetActivePatientsAsync(string patientLicenseNumber, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>>(new List<Patient>())
            : MetrcClient.GetActivePatients2Async(patientLicenseNumber, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_patients_v1_active)]
    Task<ICollection<Patient>> IPatient.GetActivePatientsAsync(string patientLicenseNumber, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Patient>>(new List<Patient>())
            : MetrcClient.GetActivePatients2Async(patientLicenseNumber, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    Task IPatient.CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePatientAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patients_v1_add)]
    Task IPatient.CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreatePatientAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    Task IPatient.UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdatePatientAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patients_v1_update)]
    Task IPatient.UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdatePatientAsync(licenseNumber, body, cancellationToken);
}