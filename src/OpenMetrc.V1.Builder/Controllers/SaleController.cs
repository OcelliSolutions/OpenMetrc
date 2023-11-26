namespace OpenMetrc.V1.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class SaleController : SalesControllerBase
{
    /// <inheritdoc cref="SalesControllerBase.GetSaleCustomerTypes" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
    public override Task GetSaleCustomerTypes() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSalePatientRegistrationLocations" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_patientregistration_locations)]
    [ProducesResponseType(typeof(List<PatientRegistrationLocation>), StatusCodes.Status200OK)]
    public override Task GetSalePatientRegistrationLocations() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryById" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_id)]
    [ProducesResponseType(typeof(SaleDelivery), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_active)]
    [ProducesResponseType(typeof(List<SaleDelivery>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryActive(
        [Required] string licenseNumber,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    [ProducesResponseType(typeof(List<SaleDelivery>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryInactive(
        [Required] string licenseNumber,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryReturnReasons" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_returnreasons)]
    [ProducesResponseType(typeof(List<DeliveryReturnReason>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryReturnReasons(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleCounties" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_counties)]
    [ProducesResponseType(typeof(List<County>), StatusCodes.Status200OK)]
    public override Task GetSaleCounties() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSalePaymentTypes" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_paymenttypes)]
    [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
    public override Task GetSalePaymentTypes(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptById" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    [ProducesResponseType(typeof(SaleReceipt), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    [ProducesResponseType(typeof(List<SaleReceipt>), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptActive(
        [Required] string licenseNumber,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    [ProducesResponseType(typeof(List<SaleReceipt>), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptInactive(
        [Required] string licenseNumber,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveries" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    public override Task PostSaleDeliveries(
        [Required] List<PostSaleDeliveriesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleReceipts" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    public override Task PostSaleReceipts(
        [Required] List<PostSaleReceiptsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHub" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub)]
    public override Task PutSaleDeliveryHub(
        [Required] List<PutSaleDeliveryHubRequest> updateSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubAccept" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_accept)]
    public override Task PutSaleDeliveryHubAccept(
        [Required] List<PutSaleDeliveryHubAcceptRequest> acceptSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryComplete" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    public override Task PutSaleDeliveryComplete(
        [Required] List<PutSaleDeliveryCompleteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubDepart" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_depart)]
    public override Task PutSaleDeliveryHubDepart(
        [Required] List<PutSaleDeliveryHubDepartRequest> departSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubVerifyId" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_verifyID)]
    public override Task PutSaleDeliveryHubVerifyId(
        [Required] List<PutSaleDeliveryHubVerifyIdRequest> verifyIdSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveries" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    public override Task PutSaleDeliveries(
        [Required] List<PutSaleDeliveriesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleReceipts" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    public override Task PutSaleReceipts(
        [Required] List<PutSaleReceiptsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleDeliveryById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_id)]
    public override Task DeleteSaleDeliveryById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleReceiptById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    public override Task DeleteSaleReceiptById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_active)]
    [ProducesResponseType(typeof(List<Retailer>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerActive(
        [Required] string licenseNumber,
        [Required] DateTimeOffset? lastModifiedStart = null,
        [Required] DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_inactive)]
    [ProducesResponseType(typeof(List<Retailer>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerInactive(
        [Required] string licenseNumber,
        [Required] DateTimeOffset? lastModifiedStart = null,
        [Required] DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerById" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_id)]
    [ProducesResponseType(typeof(Retailer), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailer" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer)]
    public override Task PostSaleDeliveryRetailer(
        [Required] List<PostSaleDeliveryRetailerRequest> createSalesDeliveryRetailerRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryRetailer" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_retailer)]
    public override Task PutSaleDeliveryRetailer(
        [Required] List<PutSaleDeliveryRetailerRequest> updateSalesDeliveryRetailerRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleDeliveryRetailerById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_retailer_id)]
    public override Task DeleteSaleDeliveryRetailerById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerDepart" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_depart)]
    public override Task PostSaleDeliveryRetailerDepart(
        [Required] List<PostSaleDeliveryRetailerDepartRequest> updateSalesDeliveryRetailerDepartRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerRestock" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_restock)]
    public override Task PostSaleDeliveryRetailerRestock(
        [Required] List<PostSaleDeliveryRetailerRestockRequest> updateSalesDeliveryRetailerRestockRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerSale" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_sale)]
    public override Task PostSaleDeliveryRetailerSale(
        [Required] List<PostSaleDeliveryRetailerSaleRequest> createSalesDeliveryRetailerSaleRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerEnd" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_end)]
    public override Task PostSaleDeliveryRetailerEnd(
        [Required] List<PostSaleDeliveryRetailerEndRequest> updateSalesDeliveryRetailerEndRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleTransactions" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    [ProducesResponseType(typeof(List<SaleTransactionSummary>), StatusCodes.Status200OK)]
    public override Task GetSaleTransactions(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleTransactionByDateRange" />
    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    [ProducesResponseType(typeof(List<SaleTransaction>), StatusCodes.Status200OK)]
    public override Task GetSaleTransactionByDateRange(
        [Required] DateOnly salesDateStart,
        [Required] DateOnly salesDateEnd,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleTransactions" />
    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    public override Task PostSaleTransactions(
        [Required] List<PostSaleTransactionsRequest> saleTransactionSummaries,
        [Required] DateOnly date,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleTransactions" />
    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    public override Task PutSaleTransactions(
        [Required] List<PutSaleTransactionsRequest> saleTransactionSummaries,
        [Required] DateOnly date,
        [Required] string licenseNumber) => Task.CompletedTask;
}