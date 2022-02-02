namespace OpenMetrc;

public interface ILabTest
{
    /// <summary>Get all lab test states</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetLabTestStatesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get all lab test states</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetLabTestStatesAsync(CancellationToken cancellationToken);

    /// <summary>Get all lab test types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LabTestType>> GetLabTestTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get all lab test types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LabTestType>> GetLabTestTypesAsync(CancellationToken cancellationToken);

    /// <summary>Get lab test results for a package</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LabTest>> GetLabTestResultsAsync(int packageId, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get lab test results for a package</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<LabTest>> GetLabTestResultsAsync(int packageId, string licenseNumber,
        CancellationToken cancellationToken);

    /// <summary>Upload the lab test results</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Upload the lab test results</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task RecordLabTestAsync(string licenseNumber, IEnumerable<CreateLabTestResultRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update lab test documents</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateLabTestDocumentAsync(string licenseNumber, IEnumerable<UpdateLabTestDocumentRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update lab test documents</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateLabTestDocumentAsync(string licenseNumber, IEnumerable<UpdateLabTestDocumentRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Release lab test results</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ReleaseLabTestResultsAsync(string licenseNumber, IEnumerable<ReleaseLabTestResultsRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Release lab test results</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task ReleaseLabTestResultsAsync(string licenseNumber, IEnumerable<ReleaseLabTestResultsRequest> body,
        CancellationToken cancellationToken);
}