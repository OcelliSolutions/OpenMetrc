using Asp.Versioning;

namespace OpenMetrc.Builder.Controllers.V2;

[Route("transfers/v2")]
[ApiVersion("2")]
[ApiController]
public class TransferController : ControllerBase
{
    [HttpGet("hub")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get incoming transfers")]
    public ActionResult GetHubTransfers(
        [Required, SwaggerParameter(Description = "The license number of the facility for which to return shipment plans")] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("incoming")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get incoming transfers")]
    public ActionResult GetIncomingTransfers(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("outgoing")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get outgoing transfers")]
    public ActionResult GetOutgoingTransfers(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("rejected")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get rejected transfers")]
    public ActionResult GetRejectedTransfers([Required] string licenseNumber) => Ok();

    [HttpGet("{id}/deliveries")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer deliveries")]
    public ActionResult GetTransferDeliveries([Required] [SwaggerParameter("Transfer ID")] long id) => Ok();

    [HttpGet("delivery/{id}/transporters")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters")]
    public ActionResult GetTransferDeliveryTransporters([Required] [SwaggerParameter("Delivery ID")] long id) => Ok();

    [HttpGet("delivery/{id}/transporters/details")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters (detail)")]
    public ActionResult GetTransferDeliveryTransportersDetail([Required] [SwaggerParameter("Delivery ID")] long id) =>
        Ok();

    [HttpGet("delivery/{id}/packages")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages")]
    public ActionResult GetTransferDeliveryPackages([Required] [SwaggerParameter("Transfer Delivery ID")] long id) =>
        Ok();

    [HttpGet("delivery/{id}/packages/wholesale")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackageWholesale>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages for wholesale")]
    public ActionResult GetTransferDeliveryPackagesWholesale(
        [Required] [SwaggerParameter("Transfer Delivery ID")]
        long id) => Ok();

    [HttpGet("delivery/package/{id}/requiredlabtestbatches")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [ProducesResponseType(typeof(MetrcWrapper<RequiredLabTestBatch>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery packages that require lab tests",
        Description =
            "Please note: The {id} parameter above represents a Transfer Delivery Package ID, not a Manifest Number.")]
    public ActionResult GetTransferDeliveryPackagesThatRequireLabTest(
        [Required] [SwaggerParameter("Transfer Delivery Package ID")]
        long id) => Ok();

    [HttpGet("delivery/packages/states")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_packages_states)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery package states")]
    public ActionResult GetTransferDeliveryPackageStates() => Ok();

    [HttpGet("types")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_types)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(MetrcWrapper<TransferType>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer types")]
    public ActionResult GetTransferTypes([Required] string licenseNumber) => Ok();

    #region External Incoming

    [HttpPost("external/incoming")]
    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Create incoming external transfer")]
    public ActionResult CreateExternalIncomingTransfers(
        [Required] string licenseNumber,
        [Required] ICollection<CreateTransferRequest> createExternalIncomingTransferRequests) => Ok();

    [HttpPut("external/incoming")]
    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Update incoming external transfer")]
    public ActionResult UpdateExternalIncomingTransfers(
        [Required] string licenseNumber,
        [Required] ICollection<UpdateTransferRequest> updateExternalIncomingTransferRequests) => Ok();

    [HttpDelete("external/incoming/{id}")]
    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Transfers })]
    [SwaggerOperation(Summary = "Delete incoming external transfer")]
    public ActionResult DeleteExternalIncomingTransfer(
        [Required] string licenseNumber,
        [Required] [SwaggerParameter("External Incoming Transfer ID")]
        long id) => Ok();

    #endregion External Incoming

    #region Templates

    [HttpGet("templates/outgoing")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer templates")]
    public ActionResult GetTransferTemplates(
        [Required] string licenseNumber,
        [SwaggerParameter("The last modified start timestamp.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter("The last modified end timestamp.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("templates/outgoing/{id}/deliveries")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery templates")]
    public ActionResult GetTransferDeliveryTemplate([Required] [SwaggerParameter("Template Transfer ID")] long id) =>
        Ok();

    [HttpGet("templates/outgoing/delivery/{id}/transporters")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporter templates")]
    public ActionResult GetTransferDeliveryTransporterTemplates(
        [Required] [SwaggerParameter("Template Delivery ID")]
        long id) => Ok();

    [HttpGet("templates/outgoing/delivery/{id}/transporters/details")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery transporters (detail) templates")]
    public ActionResult GetTransferDeliveryTransportersDetailTemplates(
        [Required] [SwaggerParameter("Template Delivery ID")]
        long id) => Ok();

    [HttpGet("templates/outgoing/delivery/{id}/packages")]
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get transfer delivery package templates")]
    public ActionResult GetTransferDeliveryPackagesTemplate(
        [Required] [SwaggerParameter("Template Transfer Delivery ID")]
        long id) => Ok();

    [HttpPost("templates/outgoing")]
    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Create transfer template")]
    public ActionResult CreateTransferTemplates(
        [Required] string licenseNumber,
        [Required] ICollection<CreateTransferRequest> createTransferTemplateRequests) => Ok();

    [HttpPut("templates/outgoing")]
    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Update transfer template")]
    public ActionResult UpdateTransferTemplates(
        [Required] string licenseNumber,
        [Required] ICollection<UpdateTransferRequest> updateTransferTemplateRequests) => Ok();

    [HttpDelete("templates/outgoing/{id}")]
    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.TransferTemplates })]
    [SwaggerOperation(Summary = "Delete transfer template")]
    public ActionResult DeleteTransferTemplate(
        [Required] string licenseNumber,
        [Required] [SwaggerParameter("Transfer Transfer ID")]
        long id) => Ok();

    #endregion Templates
}