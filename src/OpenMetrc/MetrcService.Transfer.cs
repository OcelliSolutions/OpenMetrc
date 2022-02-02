namespace OpenMetrc;

public partial class MetrcService : ITransfer
{
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>> ITransfer.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>> ITransfer.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>> ITransfer.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>> ITransfer.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>> ITransfer.GetRejectedTransfersAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetRejectedTransfersAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>> ITransfer.GetRejectedTransfersAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetRejectedTransfersAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveriesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : MetrcClient.GetTransferDeliveriesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveriesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : MetrcClient.GetTransferDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransportersAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : MetrcClient.GetTransferDeliveryTransportersAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransportersAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : MetrcClient.GetTransferDeliveryTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : MetrcClient.GetTransferDeliveryTransportersDetailAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : MetrcClient.GetTransferDeliveryTransportersDetailAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : MetrcClient.GetTransferDeliveryPackagesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : MetrcClient.GetTransferDeliveryPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>> ITransfer.GetTransferDeliveryPackagesWholesaleAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>>(
                new List<TransferDeliveryPackageWholesale>())
            : MetrcClient.GetTransferDeliveryPackagesWholesaleAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>> ITransfer.GetTransferDeliveryPackagesWholesaleAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>>(
                new List<TransferDeliveryPackageWholesale>())
            : MetrcClient.GetTransferDeliveryPackagesWholesaleAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>> ITransfer.GetTransferDeliveryPackagesThatRequireLabTestAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>>(new List<RequiredLabTestBatch>())
            : MetrcClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>> ITransfer.GetTransferDeliveryPackagesThatRequireLabTestAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>>(new List<RequiredLabTestBatch>())
            : MetrcClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_packages_states)]
    Task<ICollection<string>> ITransfer.GetTransferDeliveryPackageStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetTransferDeliveryPackageStatesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_packages_states)]
    Task<ICollection<string>> ITransfer.GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetTransferDeliveryPackageStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>> ITransfer.GetTransferTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>>(new List<TransferType>())
            : MetrcClient.GetTransferTypesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>> ITransfer.GetTransferTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>>(new List<TransferType>())
            : MetrcClient.GetTransferTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransfer.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransfer.CreateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransfer.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransfer.UpdateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransfer.DeleteExternalIncomingTransferAsync(string licenseNumber, int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteExternalIncomingTransferAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransfer.DeleteExternalIncomingTransferAsync(string licenseNumber, int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteExternalIncomingTransferAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>> ITransfer.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>> ITransfer.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : MetrcClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransfer.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransfer.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransfer.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransfer.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveryTemplateAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : MetrcClient.GetTransferDeliveryTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveryTemplateAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : MetrcClient.GetTransferDeliveryTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransporterTemplatesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : MetrcClient.GetTransferDeliveryTransporterTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransporterTemplatesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : MetrcClient.GetTransferDeliveryTransporterTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.
        GetTransferDeliveryTransportersDetailTemplatesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : MetrcClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailTemplatesAsync(
        int id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : MetrcClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesTemplateAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : MetrcClient.GetTransferDeliveryPackagesTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesTemplateAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : MetrcClient.GetTransferDeliveryPackagesTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransfer.DeleteTransferTemplateAsync(string licenseNumber, int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteTransferTemplateAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransfer.DeleteTransferTemplateAsync(string licenseNumber, int id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteTransferTemplateAsync(licenseNumber, id, cancellationToken);
}