namespace OpenMetrc.V2;

public partial class MetrcService : ITransferClient
{
    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    Task<TransferMetrcWrapper> ITransferClient.GetHubTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetHubTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_hub)]
    Task<TransferMetrcWrapper> ITransferClient.GetHubTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetHubTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    Task<TransferMetrcWrapper> ITransferClient.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_incoming)]
    Task<TransferMetrcWrapper> ITransferClient.GetIncomingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetIncomingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetOutgoingTransfersAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetOutgoingTransfersAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    Task<TransferMetrcWrapper> ITransferClient.GetRejectedTransfersAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetRejectedTransfersAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_rejected)]
    Task<TransferMetrcWrapper> ITransferClient.GetRejectedTransfersAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetRejectedTransfersAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferDeliveriesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferDeliveriesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferDeliveriesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferDeliveriesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferDeliveryTransportersAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferDeliveryTransportersAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.
        GetTransferDeliveryTransportersDetailAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersDetailAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.GetTransferDeliveryTransportersDetailAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersDetailAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    Task<TransferDeliveryPackageWholesaleMetrcWrapper> ITransferClient.
        GetTransferDeliveryPackagesWholesaleAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryPackageWholesaleMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesWholesaleAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale)]
    Task<TransferDeliveryPackageWholesaleMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesWholesaleAsync(
        long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryPackageWholesaleMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesWholesaleAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    Task<RequiredLabTestBatchMetrcWrapper> ITransferClient.
        GetTransferDeliveryPackagesThatRequireLabTestAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RequiredLabTestBatchMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches)]
    Task<RequiredLabTestBatchMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RequiredLabTestBatchMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesThatRequireLabTestAsync(id, cancellationToken);

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
    Task<TransferTypeMetrcWrapper> ITransferClient.GetTransferTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferTypeMetrcWrapper())
            : TransferClient.GetTransferTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_types)]
    Task<TransferTypeMetrcWrapper> ITransferClient.GetTransferTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferTypeMetrcWrapper())
            : TransferClient.GetTransferTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    Task ITransferClient.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_external_incoming)]
    Task ITransferClient.CreateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    Task ITransferClient.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_external_incoming)]
    Task ITransferClient.UpdateExternalIncomingTransfersAsync(string licenseNumber,
        IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateExternalIncomingTransfersAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    Task ITransferClient.DeleteExternalIncomingTransferAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteExternalIncomingTransferAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_external_incoming_id)]
    Task ITransferClient.DeleteExternalIncomingTransferAsync(string licenseNumber, long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteExternalIncomingTransferAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing)]
    Task<TransferMetrcWrapper> ITransferClient.GetTransferTemplatesAsync(string licenseNumber,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferMetrcWrapper())
            : TransferClient.GetTransferTemplatesAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    Task ITransferClient.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_transfers_v2_templates_outgoing)]
    Task ITransferClient.CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.CreateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    Task ITransferClient.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateTransferTemplatesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_transfers_v2_templates_outgoing)]
    Task ITransferClient.UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.UpdateTransferTemplatesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferDeliveryTemplateAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferDeliveryTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries)]
    Task<TransferDeliveryMetrcWrapper> ITransferClient.GetTransferDeliveryTemplateAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryMetrcWrapper())
            : TransferClient.GetTransferDeliveryTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.
        GetTransferDeliveryTransporterTemplatesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransporterTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters)]
    Task<TransferDeliveryTransporterMetrcWrapper> ITransferClient.GetTransferDeliveryTransporterTemplatesAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryTransporterMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransporterTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.
        GetTransferDeliveryTransportersDetailTemplatesAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details)]
    Task<TransferDeliveryTransporterDetailMetrcWrapper> ITransferClient.
        GetTransferDeliveryTransportersDetailTemplatesAsync(
            long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(
                new TransferDeliveryTransporterDetailMetrcWrapper())
            : TransferClient.GetTransferDeliveryTransportersDetailTemplatesAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesTemplateAsync(long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesTemplateAsync(id);

    [MapsToApi(MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages)]
    Task<TransferDeliveryPackageMetrcWrapper> ITransferClient.GetTransferDeliveryPackagesTemplateAsync(long id,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new TransferDeliveryPackageMetrcWrapper())
            : TransferClient.GetTransferDeliveryPackagesTemplateAsync(id, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    Task ITransferClient.DeleteTransferTemplateAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_transfers_v2_templates_outgoing_id)]
    Task ITransferClient.
        DeleteTransferTemplateAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : TransferClient.DeleteTransferTemplateAsync(licenseNumber, id, cancellationToken);
}