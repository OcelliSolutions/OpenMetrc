namespace OpenMetrc.V2;

public partial class MetrcService : ILabTestClient
{
    [MapsToApi(MetrcEndpoint.get_labtests_v2_states)]
    Task<StringMetrcWrapper> ILabTestClient.GetLabTestStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : LabTestClient.GetLabTestStatesAsync(cancellationToken);

    Task<LabTestBatchMetrcWrapper> ILabTestClient.GetLabTestBatchesAsync(int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LabTestBatchMetrcWrapper())
            : LabTestClient.GetLabTestBatchesAsync(pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v2_types)]
    Task<LabTestTypeMetrcWrapper> ILabTestClient.GetLabTestTypesAsync(int? pageNumber, int? pageSize, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LabTestTypeMetrcWrapper())
            : LabTestClient.GetLabTestTypesAsync(pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v2_results)]
    Task<LabTestMetrcWrapper> ILabTestClient.GetLabTestResultsAsync(long packageId, string licenseNumber, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LabTestMetrcWrapper())
            : LabTestClient.GetLabTestResultsAsync(packageId, licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_labtests_v2_record)]
    Task ILabTestClient.PostLabTestRecordAsync(string licenseNumber, IEnumerable<PostLabTestRecordRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PostLabTestRecordAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v2_labtestdocument)]
    Task ILabTestClient.PutLabTestLabTestDocumentAsync(string licenseNumber,
        IEnumerable<PutLabTestLabTestDocumentRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PutLabTestLabTestDocumentAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_labtests_v2_results_release)]
    Task ILabTestClient.PutLabTestResultReleaseAsync(string licenseNumber,
        IEnumerable<PutLabTestResultReleaseRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : LabTestClient.PutLabTestResultReleaseAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_labtests_v2_labtestdocument_id)]
    Task<LabTestMetrcWrapper> ILabTestClient.GetLabTestLabTestDocumentByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new LabTestMetrcWrapper())
            : LabTestClient.GetLabTestLabTestDocumentByIdAsync(id, licenseNumber, cancellationToken);
}