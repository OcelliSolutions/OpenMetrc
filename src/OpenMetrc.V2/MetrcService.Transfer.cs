namespace OpenMetrc.V2;

public partial class MetrcService : ITransferClient
{
    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    Task<TransferHubMetrcWrapper> ITransferClient.GetTransferHubAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferHubMetrcWrapper())
            : TransferClient.GetTransferHubAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    Task<TransferHubMetrcWrapper> ITransferClient.GetTransferHubAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferHubMetrcWrapper())
            : TransferClient.GetTransferHubAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferIncomingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferIncomingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferIncomingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferIncomingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferOutgoingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferOutgoingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferOutgoingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferOutgoingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferRejectedAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferRejectedAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferRejectedAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferRejectedAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferByIdDeliveriesAsync(long id,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferByIdDeliveriesAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferByIdDeliveriesAsync(long id,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferByIdDeliveriesAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferDeliveryByIdTransportersAsync(long id,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdTransportersAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferDeliveryByIdTransportersAsync(long id,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdTransportersAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(long id,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(
        long id,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryByIdPackagesAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdPackagesAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryByIdPackagesAsync(long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdPackagesAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    Task<TransferDeliveryPackageWholesaleMetrcWrapper> ITransferClient.
        GetTransferDeliveryByIdPackageWholesaleAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryPackageWholesaleMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdPackageWholesaleAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    Task<TransferDeliveryPackageWholesaleMetrcWrapper> ITransferClient.GetTransferDeliveryByIdPackageWholesaleAsync(
        long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryPackageWholesaleMetrcWrapper())
            : TransferClient.GetTransferDeliveryByIdPackageWholesaleAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    Task<RequiredLabTestBatchMetrcWrapper> ITransferClient.
        GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RequiredLabTestBatchMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    Task<RequiredLabTestBatchMetrcWrapper> ITransferClient.GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RequiredLabTestBatchMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_packages_states)]
    Task<StringMetrcWrapper> ITransferClient.GetTransferDeliveryPackageStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackageStatesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_packages_states)]
    Task<StringMetrcWrapper> ITransferClient.
        GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackageStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_types)]
    Task<TransferTypeMetrcWrapper> ITransferClient.GetTransferTypesAsync(string licenseNumber, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferTypeMetrcWrapper())
            : TransferClient.GetTransferTypesAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_types)]
    Task<TransferTypeMetrcWrapper> ITransferClient.GetTransferTypesAsync(string licenseNumber, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferTypeMetrcWrapper())
            : TransferClient.GetTransferTypesAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    Task ITransferClient.PostTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PostTransferExternalIncomingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferExternalIncomingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    Task ITransferClient.PostTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PostTransferExternalIncomingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferExternalIncomingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    Task ITransferClient.PutTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PutTransferExternalIncomingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferExternalIncomingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    Task ITransferClient.PutTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PutTransferExternalIncomingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferExternalIncomingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    Task ITransferClient.DeleteTransferExternalIncomingByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferExternalIncomingByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    Task ITransferClient.DeleteTransferExternalIncomingByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferExternalIncomingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    Task ITransferClient.PostTransferTemplateOutgoingAsync(string licenseNumber, IEnumerable<PostTransferTemplateOutgoingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferTemplateOutgoingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    Task ITransferClient.PostTransferTemplateOutgoingAsync(string licenseNumber, IEnumerable<PostTransferTemplateOutgoingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferTemplateOutgoingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    Task ITransferClient.PutTransferTemplateOutgoingAsync(string licenseNumber, IEnumerable<PutTransferTemplateOutgoingRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferTemplateOutgoingAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    Task ITransferClient.PutTransferTemplateOutgoingAsync(string licenseNumber, IEnumerable<PutTransferTemplateOutgoingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferTemplateOutgoingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingByIdDeliveriesAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingByIdDeliveriesAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingByIdDeliveriesAsync(long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingByIdDeliveriesAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.
        GetTransferTemplateOutgoingDeliveryByIdTransportersAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdTransportersAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingDeliveryByIdTransportersAsync(long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdTransportersAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.
        GetTransferTemplateOutgoingDeliveryByIdTransporterDetailsAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdTransporterDetailsAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.
        GetTransferTemplateOutgoingDeliveryByIdTransporterDetailsAsync(
            long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdTransporterDetailsAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingDeliveryByIdPackagesAsync(long id, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdPackagesAsync(id, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferTemplateOutgoingDeliveryByIdPackagesAsync(long id, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferTemplateOutgoingDeliveryByIdPackagesAsync(id, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    Task ITransferClient.DeleteTransferTemplateOutgoingByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateOutgoingByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    Task ITransferClient.
        DeleteTransferTemplateOutgoingByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateOutgoingByIdAsync(id, licenseNumber, cancellationToken);
}