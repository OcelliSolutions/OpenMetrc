namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class LabTestController : LabTestsControllerBase
{
    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestStates" />
    [MapsToApi(MetrcEndpoint.get_labtests_v2_states)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetLabTestStates() => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestBatches" />
    [MapsToApi(MetrcEndpoint.get_labtests_v2_batches)]
    [ProducesResponseType(typeof(MetrcWrapper<LabTestBatch>), StatusCodes.Status200OK)]
    public override Task GetLabTestBatches(
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestTypes" />
    [MapsToApi(MetrcEndpoint.get_labtests_v2_types)]
    [ProducesResponseType(typeof(MetrcWrapper<LabTestType>), StatusCodes.Status200OK)]
    public override Task GetLabTestTypes(
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestResults" />
    [MapsToApi(MetrcEndpoint.get_labtests_v2_results)]
    [ProducesResponseType(typeof(MetrcWrapper<LabTest>), StatusCodes.Status200OK)]
    public override Task GetLabTestResults(
        [Required] long packageId,
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PostLabTestRecord" />
    [MapsToApi(MetrcEndpoint.post_labtests_v2_record)]
    public override Task PostLabTestRecord(
        [Required] List<PostLabTestRecordRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PutLabTestLabTestDocument" />
    [MapsToApi(MetrcEndpoint.put_labtests_v2_labtestdocument)]
    public override Task PutLabTestLabTestDocument(
        [Required] List<PutLabTestLabTestDocumentRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PutLabTestResultRelease" />
    [MapsToApi(MetrcEndpoint.put_labtests_v2_results_release)]
    public override Task PutLabTestResultRelease(
        [Required] List<PutLabTestResultReleaseRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestLabTestDocumentById" />
    [MapsToApi(MetrcEndpoint.get_labtests_v2_labtestdocument_id)]
    [ProducesResponseType(typeof(MetrcWrapper<LabTest>), StatusCodes.Status200OK)]
    public override Task GetLabTestLabTestDocumentById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}