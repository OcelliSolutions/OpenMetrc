using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("labtests/v2")]
[ApiVersion("2")]
[ApiController]
public class LabTestController : ControllerBase
{
    [HttpGet("states")]
    [MapsToApi(MetrcEndpoint.get_labtests_v2_states)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all lab test states")]
    public ActionResult GetLabTestStates() => Ok();

    [HttpGet("batches")]
    [MapsToApi(MetrcEndpoint.get_labtests_v2_batches)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<LabTestBatch>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all lab test batches")]
    public ActionResult GetLabTestBatches() => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_labtests_v2_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<LabTestType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all lab test types")]
    public ActionResult GetLabTestTypes() => Ok();

    [HttpGet("results")]
    [MapsToApi(MetrcEndpoint.get_labtests_v2_results)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(MetrcWrapper<LabTest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get lab test results for a package")]
    public ActionResult GetLabTestResults([Required] long packageId, [Required] string licenseNumber) => Ok();

    [HttpPost("record")]
    [MapsToApi(MetrcEndpoint.post_labtests_v2_record)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Upload the lab test results")]
    public ActionResult RecordLabTest([Required] string licenseNumber,
        [Required] List<CreateLabTestResultRequest> createLabTestResultRequests) => Ok();

    [HttpPut("labtestdocument")]
    [MapsToApi(MetrcEndpoint.put_labtests_v2_labtestdocument)]
    [Authorize]
    [ApiAuthorizationFilter(new []{ ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Update lab test documents")]
    public ActionResult UpdateLabTestDocument([Required] string licenseNumber,
        [Required] List<UpdateLabTestDocumentRequest> updateLabTestDocumentRequests) => Ok();

    [HttpPut("results/release")]
    [MapsToApi(MetrcEndpoint.put_labtests_v2_results_release)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Release lab test results")]
    public ActionResult ReleaseLabTestResults([Required] string licenseNumber,
        [Required] List<ReleaseLabTestResultsRequest> releaseLabTestResultsRequests) => Ok();

    [HttpGet("labtestdocument/{id}")]
    [MapsToApi(MetrcEndpoint.get_labtests_v2_labtestdocument_id)]
    [Authorize]
    [ApiAuthorizationFilter(permissions: new []{ ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [ProducesResponseType(typeof(MetrcWrapper<LabTest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get lab test document")]
    public ActionResult GetLabTestDocument([Required] string licenseNumber,
        [Required, FromRoute] long id) => Ok();
}