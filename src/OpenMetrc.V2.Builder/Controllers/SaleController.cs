namespace OpenMetrc.V2.Builder.Controllers;

/// <inheritdoc />
[ApiController]
[Authorize]
public class SaleController : SalesControllerBase
{
    /// <inheritdoc cref="SalesControllerBase.GetSaleCustomerTypes" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_customertypes)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetSaleCustomerTypes() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSalePatientRegistrationLocations" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_patientregistration_locations)]
    [ProducesResponseType(typeof(MetrcWrapper<PatientRegistrationLocation>), StatusCodes.Status200OK)]
    public override Task GetSalePatientRegistrationLocations() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryById" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_id)]
    [ProducesResponseType(typeof(SaleDelivery), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_active)]
    [ProducesResponseType(typeof(MetrcWrapper<SaleDelivery>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<SaleDelivery>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryReturnReasons" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_returnreasons)]
    [ProducesResponseType(typeof(MetrcWrapper<DeliveryReturnReason>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryReturnReasons(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleCounties" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_counties)]
    [ProducesResponseType(typeof(MetrcWrapper<County>), StatusCodes.Status200OK)]
    public override Task GetSaleCounties() => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSalePaymentTypes" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_paymenttypes)]
    [ProducesResponseType(typeof(MetrcWrapper<string>), StatusCodes.Status200OK)]
    public override Task GetSalePaymentTypes(
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptById" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_id)]
    [ProducesResponseType(typeof(SaleReceipt), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_active)]
    [ProducesResponseType(typeof(MetrcWrapper<SaleReceipt>), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptExternal" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_external_externalNumber)]
    [ProducesResponseType(typeof(MetrcWrapper<SaleReceipt>), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptExternal([Required] string externalNumber,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleReceiptInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<SaleReceipt>), StatusCodes.Status200OK)]
    public override Task GetSaleReceiptInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        DateTimeOffset? salesDateStart = null,
        DateTimeOffset? salesDateEnd = null,
        DateTimeOffset? lastModifiedStart = null,
        DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveries" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries)]
    public override Task PostSaleDeliveries(
        [Required] List<PostSaleDeliveriesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleReceipts" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_receipts)]
    public override Task PostSaleReceipts(
        [Required] List<PostSaleReceiptsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHub" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub)]
    public override Task PutSaleDeliveryHub(
        [Required] List<PutSaleDeliveryHubRequest> updateSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubAccept" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_accept)]
    public override Task PutSaleDeliveryHubAccept(
        [Required] List<PutSaleDeliveryHubAcceptRequest> acceptSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryComplete" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_complete)]
    public override Task PutSaleDeliveryComplete(
        [Required] List<PutSaleDeliveryCompleteRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubDepart" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_depart)]
    public override Task PutSaleDeliveryHubDepart(
        [Required] List<PutSaleDeliveryHubDepartRequest> departSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryHubVerifyId" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID)]
    public override Task PutSaleDeliveryHubVerifyId(
        [Required] List<PutSaleDeliveryHubVerifyIdRequest> verifyIdSaleDeliveryHubRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleReceiptFinalize" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_finalize)]
    public override Task PutSaleReceiptFinalize([Required] 
        List<PutSaleReceiptFinalizeRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleReceiptUnfinalize" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_unfinalize)]
    public override Task PutSaleReceiptUnfinalize(
        [Required] List<PutSaleReceiptUnfinalizeRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveries" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries)]
    public override Task PutSaleDeliveries(
        [Required] List<PutSaleDeliveriesRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleReceipts" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts)]
    public override Task PutSaleReceipts(
        [Required] List<PutSaleReceiptsRequest> request,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleDeliveryById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_id)]
    public override Task DeleteSaleDeliveryById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleReceiptById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v2_receipts_id)]
    public override Task DeleteSaleReceiptById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerActive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_active)]
    [ProducesResponseType(typeof(MetrcWrapper<Retailer>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerActive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        [Required] DateTimeOffset? lastModifiedStart = null,
        [Required] DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerInactive" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive)]
    [ProducesResponseType(typeof(MetrcWrapper<Retailer>), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerInactive(
        [Required] string licenseNumber,
        int? pageNumber = null, int? pageSize = null,
        [Required] DateTimeOffset? lastModifiedStart = null,
        [Required] DateTimeOffset? lastModifiedEnd = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.GetSaleDeliveryRetailerById" />
    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_id)]
    [ProducesResponseType(typeof(Retailer), StatusCodes.Status200OK)]
    public override Task GetSaleDeliveryRetailerById(
        [Required] long id,
        string? licenseNumber = null) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailer" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer)]
    public override Task PostSaleDeliveryRetailer(
        [Required] List<PostSaleDeliveryRetailerRequest> createSalesDeliveryRetailerRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PutSaleDeliveryRetailer" />
    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_retailer)]
    public override Task PutSaleDeliveryRetailer(
        [Required] List<PutSaleDeliveryRetailerRequest> updateSalesDeliveryRetailerRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.DeleteSaleDeliveryRetailerById" />
    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_retailer_id)]
    public override Task DeleteSaleDeliveryRetailerById(
        [Required] long id,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerDepart" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_depart)]
    public override Task PostSaleDeliveryRetailerDepart(
        [Required] List<PostSaleDeliveryRetailerDepartRequest> updateSalesDeliveryRetailerDepartRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerRestock" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_restock)]
    public override Task PostSaleDeliveryRetailerRestock(
        [Required] List<PostSaleDeliveryRetailerRestockRequest> updateSalesDeliveryRetailerRestockRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerSale" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_sale)]
    public override Task PostSaleDeliveryRetailerSale(
        [Required] List<PostSaleDeliveryRetailerSaleRequest> createSalesDeliveryRetailerSaleRequest,
        [Required] string licenseNumber) => Task.CompletedTask;

    /// <inheritdoc cref="SalesControllerBase.PostSaleDeliveryRetailerEnd" />
    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_end)]
    public override Task PostSaleDeliveryRetailerEnd(
        [Required] List<PostSaleDeliveryRetailerEndRequest> updateSalesDeliveryRetailerEndRequest,
        [Required] string licenseNumber) => Task.CompletedTask;
}