namespace OpenMetrc;

public partial class MetrcService : ISaleTransaction
{
    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>> ISaleTransaction.GetTransactionsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>>(new List<SaleTransactionSummary>())
            : MetrcClient.GetTransactionsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>> ISaleTransaction.GetTransactionsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>>(new List<SaleTransactionSummary>())
            : MetrcClient.GetTransactionsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>> ISaleTransaction.GetInactiveSaleTransactionsAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>>(new List<SaleTransaction>())
            : MetrcClient.GetInactiveSaleReceipts2Async(licenseNumber, salesDateStart, salesDateEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>> ISaleTransaction.GetInactiveSaleTransactionsAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>>(new List<SaleTransaction>())
            : MetrcClient.GetInactiveSaleReceipts2Async(licenseNumber, salesDateStart, salesDateEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleTransaction.CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateSaleTransactionSummaryAsync(licenseNumber, date, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleTransaction.CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateSaleTransactionSummaryAsync(licenseNumber, date, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleTransaction.UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateSaleTransactionSummaryAsync(licenseNumber, date, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleTransaction.UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateSaleTransactionSummaryAsync(licenseNumber, date, body, cancellationToken);
}