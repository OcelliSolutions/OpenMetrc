namespace OpenMetrc.V1;

public partial class MetrcService : ITransferClient
{
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>?> ITransferClient.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>?> ITransferClient.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>?> ITransferClient.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>?> ITransferClient.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>?> ITransferClient.GetRejectedTransfersAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetRejectedTransfersAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>?> ITransferClient.GetRejectedTransfersAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetRejectedTransfersAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferDeliveriesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferDeliveriesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferDeliveriesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.GetTransferDeliveryTransportersAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferDeliveryTransportersAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.GetTransferDeliveryTransportersAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferDeliveryTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.
        GetTransferDeliveryTransportersDetailAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferDeliveryTransportersDetailAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.GetTransferDeliveryTransportersDetailAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferDeliveryTransportersDetailAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferDeliveryPackagesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferDeliveryPackagesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferDeliveryPackagesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferDeliveryPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>?> ITransferClient.
        GetTransferDeliveryPackagesWholesaleAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>?>(
                new List<TransferDeliveryPackageWholesale>())
            : TransferClient.GetTransferDeliveryPackagesWholesaleAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>?> ITransferClient.GetTransferDeliveryPackagesWholesaleAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>?>(
                new List<TransferDeliveryPackageWholesale>())
            : TransferClient.GetTransferDeliveryPackagesWholesaleAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>?> ITransferClient.
        GetTransferDeliveryPackagesThatRequireLabTestAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>?>(new List<RequiredLabTestBatch>())
            : TransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>?> ITransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>?>(new List<RequiredLabTestBatch>())
            : TransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_packages_states)]
    Task<ICollection<string>> ITransferClient.GetTransferDeliveryPackageStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : TransferClient.GetTransferDeliveryPackageStatesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v1_deliveries_packages_states)]
    Task<ICollection<string>> ITransferClient.
        GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : TransferClient.GetTransferDeliveryPackageStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>?> ITransferClient.GetTransferTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>?>(new List<TransferType>())
            : TransferClient.GetTransferTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>?> ITransferClient.GetTransferTypesAsync(string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>?>(new List<TransferType>())
            : TransferClient.GetTransferTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransferClient.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransferClient.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransferClient.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransferClient.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransferClient.DeleteExternalIncomingTransferAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteExternalIncomingTransferAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransferClient.DeleteExternalIncomingTransferAsync(string licenseNumber, long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteExternalIncomingTransferAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>?> ITransferClient.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>?>(new List<Transfer>())
            : TransferClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransferClient.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransferClient.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransferClient.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransferClient.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferDeliveryTemplateAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferDeliveryTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>?> ITransferClient.GetTransferDeliveryTemplateAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>?>(new List<TransferDelivery>())
            : TransferClient.GetTransferDeliveryTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.
        GetTransferDeliveryTransporterTemplatesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferDeliveryTransporterTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>?> ITransferClient.GetTransferDeliveryTransporterTemplatesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>?>(new List<TransferDeliveryTransporter>())
            : TransferClient.GetTransferDeliveryTransporterTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.
        GetTransferDeliveryTransportersDetailTemplatesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>?> ITransferClient.
        GetTransferDeliveryTransportersDetailTemplatesAsync(
            long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>?>(
                new List<TransferDeliveryTransporterDetail>())
            : TransferClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferDeliveryPackagesTemplateAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferDeliveryPackagesTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_deliveries_id_packages)]
    Task<ICollection<TransferDeliveryPackage>?> ITransferClient.GetTransferDeliveryPackagesTemplateAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>?>(new List<TransferDeliveryPackage>())
            : TransferClient.GetTransferDeliveryPackagesTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransferClient.DeleteTransferTemplateAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransferClient.
        DeleteTransferTemplateAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateAsync(licenseNumber, id, cancellationToken);
}