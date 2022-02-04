namespace OpenMetrc;

public partial class MetrcService : ITransfer
{
    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>> ITransfer.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_incoming)]
    Task<ICollection<Transfer>> ITransfer.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>> ITransfer.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_outgoing)]
    Task<ICollection<Transfer>> ITransfer.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>> ITransfer.GetRejectedTransfersAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetRejectedTransfersAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_rejected)]
    Task<ICollection<Transfer>> ITransfer.GetRejectedTransfersAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetRejectedTransfersAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveriesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : UserMetrcClient.GetTransferDeliveriesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveriesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : UserMetrcClient.GetTransferDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransportersAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : UserMetrcClient.GetTransferDeliveryTransportersAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransportersAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : UserMetrcClient.GetTransferDeliveryTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : UserMetrcClient.GetTransferDeliveryTransportersDetailAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : UserMetrcClient.GetTransferDeliveryTransportersDetailAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : UserMetrcClient.GetTransferDeliveryPackagesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : UserMetrcClient.GetTransferDeliveryPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>> ITransfer.GetTransferDeliveryPackagesWholesaleAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>>(
                new List<TransferDeliveryPackageWholesale>())
            : UserMetrcClient.GetTransferDeliveryPackagesWholesaleAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale)]
    Task<ICollection<TransferDeliveryPackageWholesale>> ITransfer.GetTransferDeliveryPackagesWholesaleAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackageWholesale>>(
                new List<TransferDeliveryPackageWholesale>())
            : UserMetrcClient.GetTransferDeliveryPackagesWholesaleAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>> ITransfer.GetTransferDeliveryPackagesThatRequireLabTestAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>>(new List<RequiredLabTestBatch>())
            : UserMetrcClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches)]
    Task<ICollection<RequiredLabTestBatch>> ITransfer.GetTransferDeliveryPackagesThatRequireLabTestAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<RequiredLabTestBatch>>(new List<RequiredLabTestBatch>())
            : UserMetrcClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_packages_states)]
    Task<ICollection<string>> ITransfer.GetTransferDeliveryPackageStatesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetTransferDeliveryPackageStatesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v1_delivery_packages_states)]
    Task<ICollection<string>> ITransfer.GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : UserMetrcClient.GetTransferDeliveryPackageStatesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>> ITransfer.GetTransferTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>>(new List<TransferType>())
            : UserMetrcClient.GetTransferTypesAsync();

    [MapsToApi(MetrcEndpoint.get_transfers_v1_types)]
    Task<ICollection<TransferType>> ITransfer.GetTransferTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferType>>(new List<TransferType>())
            : UserMetrcClient.GetTransferTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransfer.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_external_incoming)]
    Task ITransfer.CreateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransfer.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_external_incoming)]
    Task ITransfer.UpdateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransfer.DeleteExternalIncomingTransferAsync(string licenseNumber, int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteExternalIncomingTransferAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_external_incoming_id)]
    Task ITransfer.DeleteExternalIncomingTransferAsync(string licenseNumber, int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteExternalIncomingTransferAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>> ITransfer.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates)]
    Task<ICollection<Transfer>> ITransfer.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Transfer>>(new List<Transfer>())
            : UserMetrcClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransfer.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v1_templates)]
    Task ITransfer.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.CreateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransfer.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v1_templates)]
    Task ITransfer.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.UpdateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveryTemplateAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : UserMetrcClient.GetTransferDeliveryTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_id_deliveries)]
    Task<ICollection<TransferDelivery>> ITransfer.GetTransferDeliveryTemplateAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDelivery>>(new List<TransferDelivery>())
            : UserMetrcClient.GetTransferDeliveryTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransporterTemplatesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : UserMetrcClient.GetTransferDeliveryTransporterTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters)]
    Task<ICollection<TransferDeliveryTransporter>> ITransfer.GetTransferDeliveryTransporterTemplatesAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporter>>(new List<TransferDeliveryTransporter>())
            : UserMetrcClient.GetTransferDeliveryTransporterTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.
        GetTransferDeliveryTransportersDetailTemplatesAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : UserMetrcClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details)]
    Task<ICollection<TransferDeliveryTransporterDetail>> ITransfer.GetTransferDeliveryTransportersDetailTemplatesAsync(
        int id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryTransporterDetail>>(
                new List<TransferDeliveryTransporterDetail>())
            : UserMetrcClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesTemplateAsync(int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : UserMetrcClient.GetTransferDeliveryPackagesTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages)]
    Task<ICollection<TransferDeliveryPackage>> ITransfer.GetTransferDeliveryPackagesTemplateAsync(int id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<TransferDeliveryPackage>>(new List<TransferDeliveryPackage>())
            : UserMetrcClient.GetTransferDeliveryPackagesTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransfer.DeleteTransferTemplateAsync(string licenseNumber, int id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteTransferTemplateAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v1_templates_id)]
    Task ITransfer.DeleteTransferTemplateAsync(string licenseNumber, int id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : UserMetrcClient.DeleteTransferTemplateAsync(licenseNumber, id, cancellationToken);
}