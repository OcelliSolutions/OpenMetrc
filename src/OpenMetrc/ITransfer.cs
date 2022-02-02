namespace OpenMetrc;

public interface ITransfer
{
    /// <summary>Get incoming transfers</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetIncomingTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get incoming transfers</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetIncomingTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get outgoing transfers</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetOutgoingTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get outgoing transfers</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetOutgoingTransfersAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Get rejected transfers</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetRejectedTransfersAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get rejected transfers</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetRejectedTransfersAsync(string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Get transfer deliveries</summary>
    /// <param name="id">Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDelivery>> GetTransferDeliveriesAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer deliveries</summary>
    /// <param name="id">Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDelivery>> GetTransferDeliveriesAsync(int id, CancellationToken cancellationToken);

    /// <summary>Get transfer delivery transporters</summary>
    /// <param name="id">Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporter>> GetTransferDeliveryTransportersAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery transporters</summary>
    /// <param name="id">Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporter>> GetTransferDeliveryTransportersAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery transporters (detail)</summary>
    /// <param name="id">Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporterDetail>> GetTransferDeliveryTransportersDetailAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery transporters (detail)</summary>
    /// <param name="id">Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporterDetail>> GetTransferDeliveryTransportersDetailAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery packages</summary>
    /// <param name="id">Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackage>> GetTransferDeliveryPackagesAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery packages</summary>
    /// <param name="id">Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackage>> GetTransferDeliveryPackagesAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery packages for wholesale</summary>
    /// <param name="id">Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackageWholesale>> GetTransferDeliveryPackagesWholesaleAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery packages for wholesale</summary>
    /// <param name="id">Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackageWholesale>> GetTransferDeliveryPackagesWholesaleAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery packages that require lab tests</summary>
    /// <param name="id">Transfer Delivery Package ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<RequiredLabTestBatch>> GetTransferDeliveryPackagesThatRequireLabTestAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery packages that require lab tests</summary>
    /// <param name="id">Transfer Delivery Package ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<RequiredLabTestBatch>> GetTransferDeliveryPackagesThatRequireLabTestAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery package states</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetTransferDeliveryPackageStatesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery package states</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetTransferDeliveryPackageStatesAsync(CancellationToken cancellationToken);

    /// <summary>Get transfer types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferType>> GetTransferTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferType>> GetTransferTypesAsync(CancellationToken cancellationToken);

    /// <summary>Create incoming external transfer</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create incoming external transfer</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update incoming external transfer</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update incoming external transfer</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateExternalIncomingTransfersAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Delete incoming external transfer</summary>
    /// <param name="id">External Incoming Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteExternalIncomingTransferAsync(string licenseNumber, int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete incoming external transfer</summary>
    /// <param name="id">External Incoming Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteExternalIncomingTransferAsync(string licenseNumber, int id, CancellationToken cancellationToken);

    /// <summary>Get transfer templates</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetTransferTemplatesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer templates</summary>
    /// <param name="lastModifiedStart">The last modified start timestamp.</param>
    /// <param name="lastModifiedEnd">The last modified end timestamp.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Transfer>> GetTransferTemplatesAsync(string licenseNumber, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken);

    /// <summary>Create transfer template</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create transfer template</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateTransferTemplatesAsync(string licenseNumber, IEnumerable<CreateTransferRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Update transfer template</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update transfer template</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateTransferTemplatesAsync(string licenseNumber, IEnumerable<UpdateTransferRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery templates</summary>
    /// <param name="id">Template Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDelivery>> GetTransferDeliveryTemplateAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery templates</summary>
    /// <param name="id">Template Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDelivery>> GetTransferDeliveryTemplateAsync(int id, CancellationToken cancellationToken);

    /// <summary>Get transfer delivery transporter templates</summary>
    /// <param name="id">Template Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporter>> GetTransferDeliveryTransporterTemplatesAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery transporter templates</summary>
    /// <param name="id">Template Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporter>> GetTransferDeliveryTransporterTemplatesAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery transporters (detail) templates</summary>
    /// <param name="id">Template Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporterDetail>> GetTransferDeliveryTransportersDetailTemplatesAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery transporters (detail) templates</summary>
    /// <param name="id">Template Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryTransporterDetail>> GetTransferDeliveryTransportersDetailTemplatesAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Get transfer delivery package templates</summary>
    /// <param name="id">Template Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackage>> GetTransferDeliveryPackagesTemplateAsync(int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get transfer delivery package templates</summary>
    /// <param name="id">Template Transfer Delivery ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<TransferDeliveryPackage>> GetTransferDeliveryPackagesTemplateAsync(int id,
        CancellationToken cancellationToken);

    /// <summary>Delete transfer template</summary>
    /// <param name="id">Transfer Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteTransferTemplateAsync(string licenseNumber, int id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete transfer template</summary>
    /// <param name="id">Transfer Transfer ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteTransferTemplateAsync(string licenseNumber, int id, CancellationToken cancellationToken);
}