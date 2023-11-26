namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class TransferController : TransfersControllerBase
{
    /// <inheritdoc cref="TransfersControllerBase.GetTransferIncoming" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    [ProducesResponseType(typeof(List<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferIncoming(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferOutgoing" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    [ProducesResponseType(typeof(List<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferOutgoing(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferRejected" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    [ProducesResponseType(typeof(List<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferRejected(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferByIdDeliveries" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    [ProducesResponseType(typeof(List<TransferDelivery>), StatusCodes.Status200OK)]
    public override Task GetTransferByIdDeliveries(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdTransporters" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters)]
    [ProducesResponseType(typeof(List<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdTransporters(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdTransporterDetails" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters_details)]
    [ProducesResponseType(typeof(List<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdTransporterDetails(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdPackages" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages)]
    [ProducesResponseType(typeof(List<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdPackages(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdPackageWholesale" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages_wholesale)]
    [ProducesResponseType(typeof(List<TransferDeliveryPackageWholesale>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdPackageWholesale(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryPackageByIdRequiredLabTestBatches" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_package_id_requiredlabtestbatches)]
    [ProducesResponseType(typeof(List<RequiredLabTestBatch>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryPackageByIdRequiredLabTestBatches(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryPackageStates" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_packages_states)]
    [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryPackageStates() => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTypes" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    [ProducesResponseType(typeof(List<TransferType>), StatusCodes.Status200OK)]
    public override Task GetTransferTypes(
        [Required] string licenseNumber) => Task.CompletedTask;

    #region External Incoming

    /// <inheritdoc cref="TransfersControllerBase.PostTransferExternalIncoming" />
    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    public override Task PostTransferExternalIncoming(
        [Required] List<PostTransferExternalIncomingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PutTransferExternalIncoming" />
    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    public override Task PutTransferExternalIncoming(
        [Required] List<PutTransferExternalIncomingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.DeleteTransferExternalIncomingById" />
    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    public override Task DeleteTransferExternalIncomingById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion External Incoming

    #region Templates

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplates" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    [ProducesResponseType(typeof(List<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplates(
        [Required] string licenseNumber,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateByIdDeliveries" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    [ProducesResponseType(typeof(List<TransferDelivery>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateByIdDeliveries(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateDeliveryByIdTransporters" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters)]
    [ProducesResponseType(typeof(List<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateDeliveryByIdTransporters(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateDeliveryByIdTransporterDetails" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters_details)]
    [ProducesResponseType(typeof(List<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateDeliveryByIdTransporterDetails(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateDeliveryByIdPackages" />
    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_packages)]
    [ProducesResponseType(typeof(List<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateDeliveryByIdPackages(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PostTransferTemplates" />
    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    public override Task PostTransferTemplates(
        [Required] List<PostTransferTemplatesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PutTransferTemplates" />
    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    public override Task PutTransferTemplates(
        [Required] List<PutTransferTemplatesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.DeleteTransferTemplateById" />
    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    public override Task DeleteTransferTemplateById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion Templates
}