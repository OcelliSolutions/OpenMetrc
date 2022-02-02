namespace OpenMetrc;

public interface ISaleReceipt
{
    /// <summary>Get sale customer types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetSaleCustomerTypesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get sale customer types</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<string>> GetSaleCustomerTypesAsync(CancellationToken cancellationToken);

    /// <summary>Get active sales receipts</summary>
    /// <param name="salesDateStart">
    ///     The sales date start timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="salesDateEnd">
    ///     The sales date end timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedStart">
    ///     The last modified start timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedEnd">
    ///     The last modified end timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleReceipt>> GetActiveSaleReceiptsAsync(string licenseNumber, DateTimeOffset? salesDateStart,
        DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get active sales receipts</summary>
    /// <param name="salesDateStart">
    ///     The sales date start timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="salesDateEnd">
    ///     The sales date end timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedStart">
    ///     The last modified start timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedEnd">
    ///     The last modified end timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleReceipt>> GetActiveSaleReceiptsAsync(string licenseNumber, DateTimeOffset? salesDateStart,
        DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken);

    /// <summary>Get inactive sales receipts</summary>
    /// <param name="salesDateStart">
    ///     The sales date start timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="salesDateEnd">
    ///     The sales date end timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedStart">
    ///     The last modified start timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedEnd">
    ///     The last modified end timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleReceipt>> GetInactiveSaleReceiptsAllAsync(string licenseNumber, DateTimeOffset? salesDateStart,
        DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get inactive sales receipts</summary>
    /// <param name="salesDateStart">
    ///     The sales date start timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="salesDateEnd">
    ///     The sales date end timestamp. If specified, also specifying any of the last modified
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedStart">
    ///     The last modified start timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <param name="lastModifiedEnd">
    ///     The last modified end timestamp. If specified, also specifying any of the sales date
    ///     parameters will result in an error.
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleReceipt>> GetInactiveSaleReceiptsAllAsync(string licenseNumber, DateTimeOffset? salesDateStart,
        DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd,
        CancellationToken cancellationToken);

    /// <summary>Get a sales receipt by id</summary>
    /// <param name="id">Receipt ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Sales Receipt will be validated against the specified License Number. If
    ///     not specified, the Sales Receipt will be validated against all of the User's current Facilities. Please note that
    ///     if the Sales Receipt is not valid for the specified License Number, a 401 Unauthorized status will be returned
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<SaleReceipt> GetSaleReceiptByIdAsync(long id, string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a sales receipt by id</summary>
    /// <param name="id">Receipt ID</param>
    /// <param name="licenseNumber">
    ///     If specified, the Sales Receipt will be validated against the specified License Number. If
    ///     not specified, the Sales Receipt will be validated against all of the User's current Facilities. Please note that
    ///     if the Sales Receipt is not valid for the specified License Number, a 401 Unauthorized status will be returned
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<SaleReceipt> GetSaleReceiptByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken);

    /// <summary>Create a new sale receipt</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create a new sale receipt</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Create a new sale receipt</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Create a new sale receipt</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body,
        CancellationToken cancellationToken);

    /// <summary>Delete an sale receipt</summary>
    /// <param name="id">Sale Receipt ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteReceiptAsync(string licenseNumber, long id);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Delete an sale receipt</summary>
    /// <param name="id">Sale Receipt ID</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task DeleteReceiptAsync(string licenseNumber, long id, CancellationToken cancellationToken);
}