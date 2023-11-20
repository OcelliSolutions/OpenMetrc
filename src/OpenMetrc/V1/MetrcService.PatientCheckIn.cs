namespace OpenMetrc.V1;

public partial class MetrcService : IPatientCheckInClient
{
    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1_locations)]
    Task<ICollection<PatientCheckInLocation>?> IPatientCheckInClient.GetPatientCheckInLocationsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckInLocation>?>(new List<PatientCheckInLocation>())
            : PatientCheckInClient.GetPatientCheckInLocationsAsync();

    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1_locations)]
    Task<ICollection<PatientCheckInLocation>?> IPatientCheckInClient.GetPatientCheckInLocationsAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckInLocation>?>(new List<PatientCheckInLocation>())
            : PatientCheckInClient.GetPatientCheckInLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1)]
    Task<ICollection<PatientCheckIn>?> IPatientCheckInClient.GetPatientCheckInsAsync(string licenseNumber, DateTime? checkinDateStart, DateTime? checkinDateEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckIn>?>(new List<PatientCheckIn>())
            : PatientCheckInClient.GetPatientCheckInsAsync(licenseNumber, checkinDateStart, checkinDateEnd);

    [MapsToApi(MetrcEndpoint.get_patientcheckins_v1)]
    Task<ICollection<PatientCheckIn>?> IPatientCheckInClient.GetPatientCheckInsAsync(string licenseNumber, DateTime? checkinDateStart, DateTime? checkinDateEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientCheckIn>?>(new List<PatientCheckIn>())
            : PatientCheckInClient.GetPatientCheckInsAsync(licenseNumber, checkinDateStart, checkinDateEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_patientcheckins_v1)]
    Task IPatientCheckInClient.CreatePatientCheckInAsync(string licenseNumber, IEnumerable<CreatePatientCheckIn>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.CreatePatientCheckInAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_patientcheckins_v1)]
    Task IPatientCheckInClient.CreatePatientCheckInAsync(string licenseNumber, IEnumerable<CreatePatientCheckIn>? body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.CreatePatientCheckInAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_patientcheckins_v1)]
    Task IPatientCheckInClient.UpdatePatientCheckInAsync(string licenseNumber, IEnumerable<UpdatePatientCheckIn>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.UpdatePatientCheckInAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_patientcheckins_v1)]
    Task IPatientCheckInClient.UpdatePatientCheckInAsync(string licenseNumber, IEnumerable<UpdatePatientCheckIn>? body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.UpdatePatientCheckInAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_patientcheckins_v1_id)]
    Task IPatientCheckInClient.DeletePatientCheckInAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
    ? Task.CompletedTask
            : PatientCheckInClient.DeletePatientCheckInAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_patientcheckins_v1_id)]
    Task IPatientCheckInClient.DeletePatientCheckInAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : PatientCheckInClient.DeletePatientCheckInAsync(id, licenseNumber, cancellationToken);
}