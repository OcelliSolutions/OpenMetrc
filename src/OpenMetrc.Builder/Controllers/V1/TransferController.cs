namespace OpenMetrc.Builder.Controllers.V1;

[Route("transfers/v1")]
[ApiController]
public class TransferController : ControllerBase
{
    [HttpGet("incoming")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get incoming transfers")]
    public ActionResult GetIncomingTransfers(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("outgoing")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get outgoing transfers")]
    public ActionResult GetOutgoingTransfers(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("rejected")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get rejected transfers")]
    public ActionResult GetRejectedTransfers([Required] string licenseNumber) => Ok();

    [HttpGet("{id:int}/deliveries")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<TransferDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer deliveries")]
    public ActionResult GetTransferDeliveries([Required] [SwaggerParameter("Transfer ID")] int id) => Ok();

    [HttpGet("delivery/{id:int}/transporters")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters")]
    public ActionResult GetTransferDeliveryTransporters([Required] [SwaggerParameter("Delivery ID")] int id) => Ok();

    [HttpGet("delivery/{id:int}/transporters/details")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters (detail)")]
    public ActionResult GetTransferDeliveryTransportersDetail([Required] [SwaggerParameter("Delivery ID")] int id) =>
        Ok();

    [HttpGet("delivery/{id:int}/packages")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages")]
    public ActionResult GetTransferDeliveryPackages([Required] [SwaggerParameter("Transfer Delivery ID")] int id) =>
        Ok();

    [HttpGet("delivery/{id:int}/packages/wholesale")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryPackageWholesale>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages for wholesale")]
    public ActionResult GetTransferDeliveryPackagesWholesale(
        [Required] [SwaggerParameter("Transfer Delivery ID")]
        int id) => Ok();

    [HttpGet("delivery/package/{id:int}/requiredlabtestbatches")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(IEnumerable<RequiredLabTestBatch>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages that require lab tests",
        Description =
            "Please note: The {id} parameter above represents a Transfer Delivery Package ID, not a Manifest Number.")]
    public ActionResult GetTransferDeliveryPackagesThatRequireLabTest(
        [Required] [SwaggerParameter("Transfer Delivery Package ID")]
        int id) => Ok();

    [HttpGet("delivery/packages/states")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_packages_states)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery package states")]
    public ActionResult GetTransferDeliveryPackageStates() => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<TransferType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer types")]
    public ActionResult GetTransferTypes([Required] string licenseNumber) => Ok();

    #region External Incoming

    [HttpPost("external/incoming")]
    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Create incoming external transfer")]
    public ActionResult CreateExternalIncomingTransfers(
        [Required] string licenseNumber,
        [Required] IEnumerable<CreateTransferRequest> createExternalIncomingTransferRequests) => Ok();

    [HttpPut("external/incoming")]
    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Update incoming external transfer")]
    public ActionResult UpdateExternalIncomingTransfers(
        [Required] string licenseNumber,
        [Required] IEnumerable<UpdateTransferRequest> updateExternalIncomingTransferRequests) => Ok();

    [HttpDelete("external/incoming/{id:int}")]
    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Delete incoming external transfer")]
    public ActionResult DeleteExternalIncomingTransfer(
        [Required] string licenseNumber,
        [Required] [SwaggerParameter("External Incoming Transfer ID")]
        int id) => Ok();

    #endregion External Incoming

    #region Templates

    [HttpGet("templates")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(IEnumerable<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer templates")]
    public ActionResult GetTransferTemplates(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("templates/{id:int}/deliveries")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(IEnumerable<TransferDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery templates")]
    public ActionResult GetTransferDeliveryTemplate([Required] [SwaggerParameter("Template Transfer ID")] int id) =>
        Ok();

    [HttpGet("templates/delivery/{id:int}/transporters")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporter templates")]
    public ActionResult GetTransferDeliveryTransporterTemplates(
        [Required] [SwaggerParameter("Template Delivery ID")]
        int id) => Ok();

    [HttpGet("templates/delivery/{id:int}/transporters/details")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters (detail) templates")]
    public ActionResult GetTransferDeliveryTransportersDetailTemplates(
        [Required] [SwaggerParameter("Template Delivery ID")]
        int id) => Ok();

    [HttpGet("templates/delivery/{id:int}/packages")]
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(IEnumerable<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery package templates")]
    public ActionResult GetTransferDeliveryPackagesTemplate(
        [Required] [SwaggerParameter("Template Transfer Delivery ID")]
        int id) => Ok();

    [HttpPost("templates")]
    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Create transfer template")]
    public ActionResult CreateTransferTemplates(
        [Required] string licenseNumber,
        [Required] IEnumerable<CreateTransferRequest> createTransferTemplateRequests) => Ok();

    [HttpPut("templates")]
    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Update transfer template")]
    public ActionResult UpdateTransferTemplates(
        [Required] string licenseNumber,
        [Required] IEnumerable<UpdateTransferRequest> updateTransferTemplateRequests) => Ok();

    [HttpDelete("templates/{id:int}")]
    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Delete transfer template")]
    public ActionResult DeleteTransferTemplate(
        [Required] string licenseNumber,
        [Required] [SwaggerParameter("Transfer Transfer ID")]
        int id) => Ok();

    #endregion Templates

    //TODO: Create TransferController
}