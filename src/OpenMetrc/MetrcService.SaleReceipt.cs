namespace OpenMetrc;

public partial class MetrcService : ISaleReceipt
{
    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    Task<ICollection<string>> ISaleReceipt.GetSaleCustomerTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetSaleCustomerTypesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    Task<ICollection<string>> ISaleReceipt.GetSaleCustomerTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : MetrcClient.GetSaleCustomerTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>> ISaleReceipt.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>>(new List<SaleReceipt>())
            : MetrcClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>> ISaleReceipt.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>>(new List<SaleReceipt>())
            : MetrcClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>> ISaleReceipt.GetInactiveSaleReceiptsAllAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>>(new List<SaleReceipt>())
            : MetrcClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>> ISaleReceipt.GetInactiveSaleReceiptsAllAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>>(new List<SaleReceipt>())
            : MetrcClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    Task<SaleReceipt> ISaleReceipt.GetSaleReceiptByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : MetrcClient.GetSaleReceiptByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    Task<SaleReceipt> ISaleReceipt.GetSaleReceiptByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : MetrcClient.GetSaleReceiptByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    Task ISaleReceipt.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    Task ISaleReceipt.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.CreateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleReceipt.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleReceipt.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.UpdateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleReceipt.DeleteReceiptAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteReceiptAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleReceipt.DeleteReceiptAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : MetrcClient.DeleteReceiptAsync(licenseNumber, id, cancellationToken);
}