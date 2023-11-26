namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class TransferController : TransfersControllerBase
{
    /// <inheritdoc cref="TransfersControllerBase.GetTransferIncoming" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferIncoming(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferOutgoing" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferOutgoing(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferRejected" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferRejected(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferHub" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferHub>), StatusCodes.Status200OK)]
    public override Task GetTransferHub(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null, DateTimeOffset? lastModifiedEnd = null) =>
        Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferByIdDeliveries" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDelivery>), StatusCodes.Status200OK)]
    public override Task GetTransferByIdDeliveries(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdTransporters" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdTransporters(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdTransporterDetails" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdTransporterDetails(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdPackages" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdPackages(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryByIdPackageWholesale" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackageWholesale>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryByIdPackageWholesale(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryPackageByIdRequiredLabTestBatches" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    [ProducesResponseType(typeof(MetrcWrapper<RequiredLabTestBatch>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryPackageByIdRequiredLabTestBatches(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferDeliveryPackageStates" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_packages_states)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetTransferDeliveryPackageStates() => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTypes" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_types)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferType>), StatusCodes.Status200OK)]
    public override Task GetTransferTypes(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    #region External Incoming

    /// <inheritdoc cref="TransfersControllerBase.PostTransferExternalIncoming" />
    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    public override Task PostTransferExternalIncoming(
        [Required] List<PostTransferExternalIncomingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PutTransferExternalIncoming" />
    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    public override Task PutTransferExternalIncoming(
        [Required] List<PutTransferExternalIncomingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.DeleteTransferExternalIncomingById" />
    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    public override Task DeleteTransferExternalIncomingById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion External Incoming

    #region Templates

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateOutgoing" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    [ProducesResponseType(typeof(MetrcWrapper<Transfer>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateOutgoing(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateOutgoingByIdDeliveries" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDelivery>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateOutgoingByIdDeliveries(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateOutgoingDeliveryByIdTransporters" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporter>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateOutgoingDeliveryByIdTransporters(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateOutgoingDeliveryByIdTransporterDetails" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryTransporterDetail>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateOutgoingDeliveryByIdTransporterDetails(
        [Required] long id) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.GetTransferTemplateOutgoingDeliveryByIdPackages" />
    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    [ProducesResponseType(typeof(MetrcWrapper<TransferDeliveryPackage>), StatusCodes.Status200OK)]
    public override Task GetTransferTemplateOutgoingDeliveryByIdPackages(
        [Required] long id,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PostTransferTemplateOutgoing" />
    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    public override Task PostTransferTemplateOutgoing(
        [Required] List<PostTransferTemplateOutgoingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.PutTransferTemplateOutgoing" />
    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    public override Task PutTransferTemplateOutgoing(
        [Required] List<PutTransferTemplateOutgoingRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="TransfersControllerBase.DeleteTransferTemplateOutgoingById" />
    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    public override Task DeleteTransferTemplateOutgoingById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    #endregion Templates
}