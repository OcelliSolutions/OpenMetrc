namespace OpenMetrc.V2;

public partial class MetrcService : ISaleClient
{
    [MapsToApi(MetrcEndpoint.get_sales_v2_customertypes)]
    Task<StringMetrcWrapper> ISaleClient.GetSaleCustomerTypesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetSaleCustomerTypesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_customertypes)]
    Task<StringMetrcWrapper> ISaleClient.GetSaleCustomerTypesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetSaleCustomerTypesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_active)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetSaleDeliveryActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetSaleDeliveryActiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_active)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetSaleDeliveryActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetSaleDeliveryActiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_inactive)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetSaleDeliveryInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetSaleDeliveryInactiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd,
                lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_inactive)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetSaleDeliveryInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetSaleDeliveryInactiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd,
                lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries)]
    Task ISaleClient.PostSaleDeliveriesAsync(string licenseNumber, IEnumerable<PostSaleDeliveriesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveriesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries)]
    Task ISaleClient.PostSaleDeliveriesAsync(string licenseNumber, IEnumerable<PostSaleDeliveriesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveriesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries)]
    Task ISaleClient.PutSaleDeliveriesAsync(string licenseNumber, IEnumerable<PutSaleDeliveriesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveriesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries)]
    Task ISaleClient.PutSaleDeliveriesAsync(string licenseNumber, IEnumerable<PutSaleDeliveriesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveriesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_complete)]
    Task ISaleClient.PutSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryCompleteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryCompleteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_complete)]
    Task ISaleClient.PutSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryCompleteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryCompleteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_depart)]
    Task ISaleClient.PutSaleDeliveryHubDepartAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubDepartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubDepartAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_depart)]
    Task ISaleClient.PutSaleDeliveryHubDepartAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubDepartRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubDepartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID)]
    Task ISaleClient.PutSaleDeliveryHubVerifyIdAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryHubVerifyIdRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubVerifyIdAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID)]
    Task ISaleClient.PutSaleDeliveryHubVerifyIdAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryHubVerifyIdRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubVerifyIdAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_finalize)]
    Task ISaleClient.PutSaleReceiptFinalizeAsync(string licenseNumber, IEnumerable<PutSaleReceiptFinalizeRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptFinalizeAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_finalize)]
    Task ISaleClient.PutSaleReceiptFinalizeAsync(string licenseNumber, IEnumerable<PutSaleReceiptFinalizeRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptFinalizeAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_unfinalize)]
    Task ISaleClient.PutSaleReceiptUnfinalizeAsync(string licenseNumber, IEnumerable<PutSaleReceiptUnfinalizeRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptUnfinalizeAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_unfinalize)]
    Task ISaleClient.PutSaleReceiptUnfinalizeAsync(string licenseNumber, IEnumerable<PutSaleReceiptUnfinalizeRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptUnfinalizeAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_active)]
    Task<RetailerMetrcWrapper> ISaleClient.GetSaleDeliveryRetailerActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetSaleDeliveryRetailerActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_active)]
    Task<RetailerMetrcWrapper> ISaleClient.GetSaleDeliveryRetailerActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetSaleDeliveryRetailerActiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive)]
    Task<RetailerMetrcWrapper> ISaleClient.GetSaleDeliveryRetailerInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetSaleDeliveryRetailerInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive)]
    Task<RetailerMetrcWrapper> ISaleClient.GetSaleDeliveryRetailerInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetSaleDeliveryRetailerInactiveAsync(licenseNumber, pageNumber, pageSize, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetSaleDeliveryRetailerByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetSaleDeliveryRetailerByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetSaleDeliveryRetailerByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetSaleDeliveryRetailerByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_retailer_id)]
    Task ISaleClient.DeleteSaleDeliveryRetailerByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryRetailerByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_retailer_id)]
    Task ISaleClient.DeleteSaleDeliveryRetailerByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryRetailerByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer)]
    Task ISaleClient.PostSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer)]
    Task ISaleClient.PostSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_retailer)]
    Task ISaleClient.PutSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_retailer)]
    Task ISaleClient.PutSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_depart)]
    Task ISaleClient.PostSaleDeliveryRetailerDepartAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerDepartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerDepartAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_depart)]
    Task ISaleClient.PostSaleDeliveryRetailerDepartAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerDepartRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerDepartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_restock)]
    Task ISaleClient.PostSaleDeliveryRetailerRestockAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRestockRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerRestockAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_restock)]
    Task ISaleClient.PostSaleDeliveryRetailerRestockAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRestockRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerRestockAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_sale)]
    Task ISaleClient.PostSaleDeliveryRetailerSaleAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerSaleRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerSaleAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_sale)]
    Task ISaleClient.PostSaleDeliveryRetailerSaleAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerSaleRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerSaleAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_end)]
    Task ISaleClient.PostSaleDeliveryRetailerEndAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerEndRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerEndAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_end)]
    Task ISaleClient.PostSaleDeliveryRetailerEndAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerEndRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerEndAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_counties)]
    Task<CountyMetrcWrapper> ISaleClient.GetSaleCountiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CountyMetrcWrapper())
            : SaleClient.GetSaleCountiesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_counties)]
    Task<CountyMetrcWrapper> ISaleClient.GetSaleCountiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CountyMetrcWrapper())
            : SaleClient.GetSaleCountiesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_paymenttypes)]
    Task<StringMetrcWrapper> ISaleClient.GetSalePaymentTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetSalePaymentTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_paymenttypes)]
    Task<StringMetrcWrapper> ISaleClient.GetSalePaymentTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetSalePaymentTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub)]
    Task ISaleClient.PutSaleDeliveryHubAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub)]
    Task ISaleClient.PutSaleDeliveryHubAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_accept)]
    Task ISaleClient.PutSaleDeliveryHubAcceptAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubAcceptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAcceptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_accept)]
    Task ISaleClient.PutSaleDeliveryHubAcceptAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubAcceptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAcceptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_returnreasons)]
    Task<DeliveryReturnReasonMetrcWrapper> ISaleClient.GetSaleDeliveryReturnReasonsAsync(string licenseNumber,
        int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new DeliveryReturnReasonMetrcWrapper())
            : SaleClient.GetSaleDeliveryReturnReasonsAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_returnreasons)]
    Task<DeliveryReturnReasonMetrcWrapper> ISaleClient.GetSaleDeliveryReturnReasonsAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new DeliveryReturnReasonMetrcWrapper())
            : SaleClient.GetSaleDeliveryReturnReasonsAsync(licenseNumber, pageNumber, pageSize, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_patientregistration_locations)]
    Task<PatientRegistrationLocationMetrcWrapper> ISaleClient.GetSalePatientRegistrationLocationsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientRegistrationLocationMetrcWrapper())
            : SaleClient.GetSalePatientRegistrationLocationsAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_patientregistration_locations)]
    Task<PatientRegistrationLocationMetrcWrapper> ISaleClient.GetSalePatientRegistrationLocationsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientRegistrationLocationMetrcWrapper())
            : SaleClient.GetSalePatientRegistrationLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_id)]
    Task ISaleClient.DeleteSaleDeliveryByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_id)]
    Task ISaleClient.DeleteSaleDeliveryByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_active)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetSaleReceiptActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetSaleReceiptActiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_active)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetSaleReceiptActiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetSaleReceiptActiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_inactive)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetSaleReceiptInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetSaleReceiptInactiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_inactive)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetSaleReceiptInactiveAsync(string licenseNumber,
        int? pageNumber, int? pageSize,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd,
        DateTimeOffset? lastModifiedStart, DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetSaleReceiptInactiveAsync(licenseNumber, pageNumber, pageSize, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_id)]
    Task<SaleReceipt> ISaleClient.GetSaleReceiptByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : SaleClient.GetSaleReceiptByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_id)]
    Task<SaleReceipt> ISaleClient.GetSaleReceiptByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceipt())
            : SaleClient.GetSaleReceiptByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_receipts)]
    Task ISaleClient.PostSaleReceiptsAsync(string licenseNumber, IEnumerable<PostSaleReceiptsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleReceiptsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_receipts)]
    Task ISaleClient.PostSaleReceiptsAsync(string licenseNumber, IEnumerable<PostSaleReceiptsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleReceiptsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts)]
    Task ISaleClient.PutSaleReceiptsAsync(string licenseNumber, IEnumerable<PutSaleReceiptsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts)]
    Task ISaleClient.PutSaleReceiptsAsync(string licenseNumber, IEnumerable<PutSaleReceiptsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_receipts_id)]
    Task ISaleClient.DeleteSaleReceiptByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleReceiptByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_receipts_id)]
    Task ISaleClient.DeleteSaleReceiptByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleReceiptByIdAsync(id, licenseNumber, cancellationToken);
}