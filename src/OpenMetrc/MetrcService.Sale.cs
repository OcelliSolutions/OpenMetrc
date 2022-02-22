namespace OpenMetrc;

public partial class MetrcService : ISaleClient
{
    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    Task<ICollection<string>> ISaleClient.GetSaleCustomerTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : SaleClient.GetSaleCustomerTypesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    Task<ICollection<string>> ISaleClient.GetSaleCustomerTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : SaleClient.GetSaleCustomerTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_active)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetActiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetActiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_active)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetActiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetActiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetInactiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetInactiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetInactiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetInactiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    Task ISaleClient.CreateSaleDeliveryAsync(string licenseNumber, IEnumerable<CreateSaleDeliveryRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleDeliveryAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    Task ISaleClient.CreateSaleDeliveryAsync(string licenseNumber, IEnumerable<CreateSaleDeliveryRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleDeliveryAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    Task ISaleClient.UpdateSaleDeliveryAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    Task ISaleClient.UpdateSaleDeliveryAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    Task ISaleClient.UpdateSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<UpdateSaleDeliveryCompleteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryCompleteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    Task ISaleClient.UpdateSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<UpdateSaleDeliveryCompleteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryCompleteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_returnreasons)]
    Task<ICollection<DeliveryReturnReason>?> ISaleClient.GetDeliveryReturnReasonsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<DeliveryReturnReason>?>(new List<DeliveryReturnReason>())
            : SaleClient.GetDeliveryReturnReasonsAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_returnreasons)]
    Task<ICollection<DeliveryReturnReason>?> ISaleClient.GetDeliveryReturnReasonsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<DeliveryReturnReason>?>(new List<DeliveryReturnReason>())
            : SaleClient.GetDeliveryReturnReasonsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_delivery_id)]
    Task ISaleClient.DeleteDeliveryAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveryAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_delivery_id)]
    Task ISaleClient.DeleteDeliveryAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveryAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetInactiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetInactiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    Task<SaleReceipt> ISaleClient.GetSaleReceiptByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : SaleClient.GetSaleReceiptByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    Task<SaleReceipt> ISaleClient.GetSaleReceiptByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : SaleClient.GetSaleReceiptByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    Task ISaleClient.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    Task ISaleClient.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleClient.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleClient.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleClient.DeleteReceiptAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteReceiptAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleClient.DeleteReceiptAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteReceiptAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>?> ISaleClient.GetTransactionsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>?>(new List<SaleTransactionSummary>())
            : SaleClient.GetTransactionsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>?> ISaleClient.GetTransactionsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>?>(new List<SaleTransactionSummary>())
            : SaleClient.GetTransactionsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>?> ISaleClient.GetTransactionsByDateRangeAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>?>(new List<SaleTransaction>())
            : SaleClient.GetTransactionsByDateRangeAsync(licenseNumber, salesDateStart, salesDateEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>?> ISaleClient.GetTransactionsByDateRangeAsync(string licenseNumber,
        DateTimeOffset salesDateStart, DateTimeOffset salesDateEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>?>(new List<SaleTransaction>())
            : SaleClient.GetTransactionsByDateRangeAsync(licenseNumber, salesDateStart, salesDateEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleClient.CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleTransactionSummaryAsync(licenseNumber, date, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleClient.CreateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary>? body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleTransactionSummaryAsync(licenseNumber, date, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleClient.UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary>? body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleTransactionSummaryAsync(licenseNumber, date, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleClient.UpdateSaleTransactionSummaryAsync(string licenseNumber, DateTimeOffset date,
        IEnumerable<SaleTransactionSummary>? body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleTransactionSummaryAsync(licenseNumber, date, body, cancellationToken);
}