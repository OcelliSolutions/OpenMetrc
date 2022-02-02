namespace OpenMetrc.Builder.Controllers.V1;

[Route("labtests/v1")]
[ApiController]
public class LabTestController : ControllerBase
{
    [HttpGet("states")]
    [MapsToApi(MetrcEndpoint.get_labtests_v1_states)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all lab test states")]
    public ActionResult GetLabTestStates() => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_labtests_v1_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<LabTestType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get all lab test types")]
    public ActionResult GetLabTestTypes() => Ok();

    [HttpGet("results")]
    [MapsToApi(MetrcEndpoint.get_labtests_v1_results)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages })]
    [ProducesResponseType(typeof(IEnumerable<LabTest>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get lab test results for a package")]
    public ActionResult GetLabTestResults([Required] int packageId, [Required] string licenseNumber) => Ok();

    [HttpPost("record")]
    [MapsToApi(MetrcEndpoint.post_labtests_v1_record)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Upload the lab test results")]
    public ActionResult RecordLabTest([Required] string licenseNumber,
        List<CreateLabTestResultRequest> createLabTestResultRequests) => Ok();

    [HttpPut("labtestdocument")]
    [MapsToApi(MetrcEndpoint.put_labtests_v1_labtestdocument)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Update lab test documents")]
    public ActionResult UpdateLabTestDocument([Required] string licenseNumber,
        List<UpdateLabTestDocumentRequest> updateLabTestDocumentRequests) => Ok();

    [HttpPut("results/release")]
    [MapsToApi(MetrcEndpoint.put_labtests_v1_results_release)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.ViewPackages, ApiPermission.ManagePackagesInventory })]
    [SwaggerOperation(Summary = "Release lab test results")]
    public ActionResult ReleaseLabTestResults([Required] string licenseNumber,
        List<ReleaseLabTestResultsRequest> releaseLabTestResultsRequests) => Ok();
}