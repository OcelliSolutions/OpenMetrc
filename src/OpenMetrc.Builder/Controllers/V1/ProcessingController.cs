namespace OpenMetrc.Builder.Controllers.V1;

[Route("processing/v1")]
[ApiController]
public class ProcessingController : ControllerBase
{
    #region Processing

    [HttpGet("{id:long}")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(Processing), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a specific processing by id")]
    public ActionResult GetProcessingById(
        [Required] [SwaggerParameter(Description = "Processing ID")]
        long id,
        [SwaggerParameter(Description =
            "If specified, the Processing will be validated against the specified License Number. If not specified, the Processing will be validated against all of the User's current Facilities. Please note that if the Processing is not valid for the specified License Number, a 401 Unauthorized status will be returned.")]
        string licenseNumber
    ) => Ok();

    [HttpGet("active")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<Processing>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get processing in an active status")]
    public ActionResult GetActiveProcessing(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active processing.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("inactive")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<Processing>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get processing in an inactive status")]
    public ActionResult GetInactiveProcessing(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive processing.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpPost("createpackages")]
    [MapsToApi(MetrcEndpoint.post_processing_v1_createpackages)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Create packages from a processing")]
    public ActionResult CreateProcessingPackage([Required] string licenseNumber,
        [Required] List<CreateProcessingPackageRequest> createProcessingPackages) => Ok();

    [HttpPost("start")]
    [MapsToApi(MetrcEndpoint.post_processing_v1_start)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Start processing")]
    public ActionResult StartProcessing([Required] string licenseNumber,
        [Required] List<StartProcessingRequest> createProcessingPackages) => Ok();

    [HttpPost("adjust")]
    [MapsToApi(MetrcEndpoint.post_processing_v1_adjust)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Adjust processing")]
    public ActionResult AdjustProcessing([Required] string licenseNumber,
        [Required] List<AdjustProcessingRequest> adjustProcessingRequests) => Ok();

    [HttpPut("finish")]
    [MapsToApi(MetrcEndpoint.put_processing_v1_finish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Finish processing")]
    public ActionResult FinishProcessing([Required] string licenseNumber,
        [Required] List<FinishProcessingRequest> finishProcessingRequests) => Ok();

    [HttpPut("unfinish")]
    [MapsToApi(MetrcEndpoint.put_processing_v1_unfinish)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Unfinish processing")]
    public ActionResult UnfinishProcessing([Required] string licenseNumber,
        [Required] List<UnfinishProcessingRequest> unfinishProcessingRequests) => Ok();

    [HttpDelete("{id:long}")]
    [MapsToApi(MetrcEndpoint.delete_processing_v1_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Delete processing")]
    public ActionResult DeleteProcessing([Required] string licenseNumber, [Required] long id) => Ok();

    #endregion Processing

    #region JobType

    [HttpGet("jobtypes/active")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<ProcessingJobType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active job types")]
    public ActionResult GetActiveJobTypes(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of active processing.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("jobtypes/inactive")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<ProcessingJobType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive job types")]
    public ActionResult GetInactiveJobTypes(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the list of inactive processing.")]
        string licenseNumber,
        [SwaggerParameter("The last modified start timestamp")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpPost("jobtypes")]
    [MapsToApi(MetrcEndpoint.post_processing_v1_jobtypes)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(ProcessingResponse), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Create Job Type")]
    public ActionResult CreateJobType([Required] string licenseNumber,
        [Required] List<CreateJobTypeRequest> createJobTypeRequests) => Ok();

    [HttpPut("jobtypes")]
    [MapsToApi(MetrcEndpoint.put_processing_v1_jobtypes)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Update Job Type")]
    public ActionResult UpdateJobType([Required] string licenseNumber,
        [Required] List<ProcessingJobType> updateJobTypeRequests) => Ok();

    [HttpDelete("jobtypes/{id:long}")]
    [MapsToApi(MetrcEndpoint.delete_processing_v1_jobtypes_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [SwaggerOperation(Summary = "Delete job type")]
    public ActionResult DeleteJobType([Required] string licenseNumber, [Required] long id) => Ok();

    [HttpGet("jobtypes/attributes")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_attributes)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get job type attributes")]
    public ActionResult GetJobTypeAttributes(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the job type attributes.")]
        string licenseNumber
    ) => Ok();


    [HttpGet("jobtypes/categories")]
    [MapsToApi(MetrcEndpoint.get_processing_v1_jobtypes_categories)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ManageProcessingJob })]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get job type categories")]
    public ActionResult GetJobTypeCategories(
        [Required]
        [SwaggerParameter(Description =
            "The license number of the facility for which to return the job type categories.")]
        string licenseNumber
    ) => Ok();

    #endregion JobType
}