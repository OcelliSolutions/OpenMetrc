namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class ProcessingController : ProcessingJobControllerBase
{
    #region Processing

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingById" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_id)]
    [ProducesResponseType(typeof(Processing), StatusCodes.Status200OK)]
    public override Task GetProcessingById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingActive" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_active)]
    [ProducesResponseType(typeof(IEnumerable<Processing>), StatusCodes.Status200OK)]
    public override Task GetProcessingActive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingInactive" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_inactive)]
    [ProducesResponseType(typeof(IEnumerable<Processing>), StatusCodes.Status200OK)]
    public override Task GetProcessingInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PostProcessingCreatePackages" />
    [MapsToApi(MetrcEndpoint.post_processing_v1_createpackages)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostProcessingCreatePackages(
        [Required] List<PostProcessingCreatePackagesRequest> createProcessingPackages,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PostProcessingStart" />
    [MapsToApi(MetrcEndpoint.post_processing_v1_start)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostProcessingStart(
        [Required] List<PostProcessingStartRequest> createProcessingPackages,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PostProcessingAdjust" />
    [MapsToApi(MetrcEndpoint.post_processing_v1_adjust)]
    public override Task PostProcessingAdjust(
        [Required] List<PostProcessingAdjustRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PutProcessingFinish" />
    [MapsToApi(MetrcEndpoint.put_processing_v1_finish)]
    public override Task PutProcessingFinish(
        [Required] List<PutProcessingFinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PutProcessingUnfinish" />
    [MapsToApi(MetrcEndpoint.put_processing_v1_unfinish)]
    public override Task PutProcessingUnfinish(
        [Required] List<PutProcessingUnfinishRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.DeleteProcessingById" />
    [MapsToApi(MetrcEndpoint.delete_processing_v1_id)]
    public override Task DeleteProcessingById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion Processing

    #region JobType

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingJobTypeActive" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_active)]
    [ProducesResponseType(typeof(IEnumerable<ProcessingJobType>), StatusCodes.Status200OK)]
    public override Task GetProcessingJobTypeActive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingJobTypeInactive" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_inactive)]
    [ProducesResponseType(typeof(IEnumerable<ProcessingJobType>), StatusCodes.Status200OK)]
    public override Task GetProcessingJobTypeInactive(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PostProcessingJobTypes" />
    [MapsToApi(MetrcEndpoint.post_processing_v1_jobtypes)]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    public override Task PostProcessingJobTypes(
        [Required] List<PostProcessingJobTypesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.PutProcessingJobTypes" />
    [MapsToApi(MetrcEndpoint.put_processing_v1_jobtypes)]
    public override Task PutProcessingJobTypes(
        [Required] List<PutProcessingJobTypesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.DeleteProcessingJobTypeById" />
    [MapsToApi(MetrcEndpoint.delete_processing_v1_jobtypes_id)]
    public override Task DeleteProcessingJobTypeById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingJobTypeAttributes" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_attributes)]
    [ProducesResponseType(typeof(IEnumerable<JobTypeAttribute>), StatusCodes.Status200OK)]
    public override Task GetProcessingJobTypeAttributes(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="ProcessingJobControllerBase.GetProcessingJobTypeCategories" />
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_categories)]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    public override Task GetProcessingJobTypeCategories(
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion JobType
}