namespace OpenMetrc.V1;

public partial class MetrcService : ITransferClient
{
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferIncomingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferIncomingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferOutgoingAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferOutgoingAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferRejectedAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferRejectedAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferByIdDeliveriesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferByIdDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.GetTransferDeliveryByIdTransportersAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferDeliveryByIdTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferDeliveryByIdTransporterDetailsAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferDeliveryByIdPackagesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferDeliveryByIdPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>?> ITransferClient.GetTransferDeliveryByIdPackageWholesaleAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>?>(
                new List<TransferDeliveryPackageWholesale>())
            : TransferClient.GetTransferDeliveryByIdPackageWholesaleAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>?> ITransferClient.GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>?>(new List<RequiredLabTestBatch>())
            : TransferClient.GetTransferDeliveryPackageByIdRequiredLabTestBatchesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_packages_states)]
    Task<ICollection<string>> ITransferClient.
        GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : TransferClient.GetTransferDeliveryPackageStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>?> ITransferClient.GetTransferTypesAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>?>(new List<TransferType>())
            : TransferClient.GetTransferTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransferClient.PostTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PostTransferExternalIncomingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferExternalIncomingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransferClient.PutTransferExternalIncomingAsync(string licenseNumber,
        IEnumerable<PutTransferExternalIncomingRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferExternalIncomingAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransferClient.DeleteTransferExternalIncomingByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferExternalIncomingByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransferClient.PostTransferTemplatesAsync(string licenseNumber, IEnumerable<PostTransferTemplatesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PostTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransferClient.PutTransferTemplatesAsync(string licenseNumber, IEnumerable<PutTransferTemplatesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.PutTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferTemplateByIdDeliveriesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferTemplateByIdDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.GetTransferTemplateDeliveryByIdTransportersAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferTemplateDeliveryByIdTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.
        GetTransferTemplateDeliveryByIdTransporterDetailsAsync(
            long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferTemplateDeliveryByIdTransporterDetailsAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferTemplateDeliveryByIdPackagesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferTemplateDeliveryByIdPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransferClient.
        DeleteTransferTemplateByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateByIdAsync(id, licenseNumber, cancellationToken);
}