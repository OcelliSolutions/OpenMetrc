namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class LabTestController : LabTestsControllerBase
{
    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestStates" />
    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetLabTestStates() => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestTypes" />
    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    [ProducesResponseType(typeof(IEnumerable<LabTestType>), StatusCodes.Status200OK)]
    public override Task GetLabTestTypes() => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestResults" />
    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    [ProducesResponseType(typeof(IEnumerable<LabTest>), StatusCodes.Status200OK)]
    public override Task GetLabTestResults(
        [Required] long packageId,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PostLabTestRecord" />
    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    public override Task PostLabTestRecord(
        [Required] List<PostLabTestRecordRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PutLabTestLabTestDocument" />
    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    public override Task PutLabTestLabTestDocument(
        [Required] List<PutLabTestLabTestDocumentRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.PutLabTestResultRelease" />
    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    public override Task PutLabTestResultRelease(
        [Required] List<PutLabTestResultReleaseRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="LabTestsControllerBase.GetLabTestLabTestDocumentById" />
    [MapsToApi(MetrcEndpoint.get_labtests_v1_labtestdocument_id)]
    [ProducesResponseType(typeof(IEnumerable<LabTest>), StatusCodes.Status200OK)]
    public override Task GetLabTestLabTestDocumentById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;
}