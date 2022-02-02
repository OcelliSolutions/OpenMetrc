namespace OpenMetrc;

public interface ISaleTransaction
{
    /// <summary>Get a summary of all sales</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of dates with sales
    ///     transactions
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleTransactionSummary>> GetTransactionsAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a summary of all sales</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of dates with sales
    ///     transactions
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleTransactionSummary>> GetTransactionsAsync(string licenseNumber,
        CancellationToken cancellationToken);

    /// <summary>Get a detail of all sales between a date range</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of sales transactions for
    ///     the specified date range
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleTransaction>> GetInactiveSaleTransactionsAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get a detail of all sales between a date range</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to return the list of sales transactions for
    ///     the specified date range
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<SaleTransaction>> GetInactiveSaleTransactionsAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd, CancellationToken cancellationToken);

    /// <summary>Upload a sales summary</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to append the sales transactions on the
    ///     specified date
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Upload a sales summary</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to append the sales transactions on the
    ///     specified date
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body, CancellationToken cancellationToken);

    /// <summary>Update a sales summary</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to update the sales transactions on the
    ///     specified date
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Update a sales summary</summary>
    /// <param name="licenseNumber">
    ///     The license number of the facility for which to update the sales transactions on the
    ///     specified date
    /// </param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body, CancellationToken cancellationToken);
}