namespace OpenMetrc;

public interface IPatient
{
    /// <summary>Get a specific patient by id</summary>
    /// <param name="id">Patient ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Patient will be validated against the specified License Number. If not
    ///     specified, the Patient will be validated against all of the User's current Facilities. Please note that if the
    ///     Patient is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Patient> GetPatientByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a specific patient by id</summary>
    /// <param name="id">Patient ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Patient will be validated against the specified License Number. If not
    ///     specified, the Patient will be validated against all of the User's current Facilities. Please note that if the
    ///     Patient is not valid for the specified License Number, a 401 Unauthorized status will be returned.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Patient> GetPatientByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Delete an patient</summary>
    /// <param name="id">Patient ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeletePatientAsync(string licenseNumber, long id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete an patient</summary>
    /// <param name="id">Patient ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeletePatientAsync(string licenseNumber, long id, CancellationToken cancellationToken);

    /// <summary>Get active patients</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active patients.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Patient>> GetActivePatientsAllAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active patients</summary>
    /// <param name="licenseNumber">The license number of the facility for which to return the list of active patients.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Patient>> GetActivePatientsAllAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get active patients</summary>
    /// <param name="licenseNumber">The license number of the Facility under which to get the Patient Status.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Patient>> GetActivePatientsAsync(string patientLicenseNumber, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active patients</summary>
    /// <param name="licenseNumber">The license number of the Facility under which to get the Patient Status.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Patient>> GetActivePatientsAsync(string patientLicenseNumber, string licenseNumber,
        CancellationToken cancellationToken);

    /// <summary>Create patients</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create patients</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreatePatientAsync(string licenseNumber, IEnumerable<CreatePatientRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update patients</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update patients</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdatePatientAsync(string licenseNumber, IEnumerable<UpdatePatientRequest> body,
        CancellationToken cancellationToken);
}