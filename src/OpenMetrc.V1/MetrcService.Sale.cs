namespace OpenMetrc.V1;

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
    Task<ICollection<SaleDelivery>?> ISaleClient.GetSaleDeliveryActiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetSaleDeliveryActiveAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_active)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetSaleDeliveryActiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetSaleDeliveryActiveAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetSaleDeliveryInactiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetSaleDeliveryInactiveAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    Task<ICollection<SaleDelivery>?> ISaleClient.GetSaleDeliveryInactiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleDelivery>?>(new List<SaleDelivery>())
            : SaleClient.GetSaleDeliveryInactiveAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_id)]
    Task<SaleDelivery> ISaleClient.GetSaleDeliveryByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDelivery())
            : SaleClient.GetSaleDeliveryByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    Task ISaleClient.PostSaleDeliveriesAsync(string licenseNumber, IEnumerable<PostSaleDeliveriesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveriesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    Task ISaleClient.PostSaleDeliveriesAsync(string licenseNumber, IEnumerable<PostSaleDeliveriesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveriesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    Task ISaleClient.PutSaleDeliveriesAsync(string licenseNumber, IEnumerable<PutSaleDeliveriesRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveriesAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    Task ISaleClient.PutSaleDeliveriesAsync(string licenseNumber, IEnumerable<PutSaleDeliveriesRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveriesAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    Task ISaleClient.PutSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryCompleteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryCompleteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    Task ISaleClient.PutSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryCompleteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryCompleteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_depart)]
    Task ISaleClient.PutSaleDeliveryHubDepartAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubDepartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubDepartAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_depart)]
    Task ISaleClient.PutSaleDeliveryHubDepartAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubDepartRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubDepartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_verifyID)]
    Task ISaleClient.PutSaleDeliveryHubVerifyIdAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryHubVerifyIdRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubVerifyIdAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_verifyID)]
    Task ISaleClient.PutSaleDeliveryHubVerifyIdAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryHubVerifyIdRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubVerifyIdAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_active)]
    Task<ICollection<Retailer>?> ISaleClient.GetSaleDeliveryRetailerActiveAsync(string licenseNumber,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Retailer>?>(new List<Retailer>())
            : SaleClient.GetSaleDeliveryRetailerActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_active)]
    Task<ICollection<Retailer>?> ISaleClient.GetSaleDeliveryRetailerActiveAsync(string licenseNumber,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Retailer>?>(new List<Retailer>())
            : SaleClient.GetSaleDeliveryRetailerActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_inactive)]
    Task<ICollection<Retailer>?> ISaleClient.GetSaleDeliveryRetailerInactiveAsync(string licenseNumber,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Retailer>?>(new List<Retailer>())
            : SaleClient.GetSaleDeliveryRetailerInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_inactive)]
    Task<ICollection<Retailer>?> ISaleClient.GetSaleDeliveryRetailerInactiveAsync(string licenseNumber,
        DateTimeOffset lastModifiedStart, DateTimeOffset lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Retailer>?>(new List<Retailer>())
            : SaleClient.GetSaleDeliveryRetailerInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetSaleDeliveryRetailerByIdAsync(long id, string? licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetSaleDeliveryRetailerByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetSaleDeliveryRetailerByIdAsync(long id, string? licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetSaleDeliveryRetailerByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_retailer_id)]
    Task ISaleClient.DeleteSaleDeliveryRetailerByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryRetailerByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_retailer_id)]
    Task ISaleClient.DeleteSaleDeliveryRetailerByIdAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryRetailerByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer)]
    Task ISaleClient.PostSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod()) 
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer)]
    Task ISaleClient.PostSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_retailer)]
    Task ISaleClient.PutSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_retailer)]
    Task ISaleClient.PutSaleDeliveryRetailerAsync(string licenseNumber,
        IEnumerable<PutSaleDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_depart)]
    Task ISaleClient.PostSaleDeliveryRetailerDepartAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerDepartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerDepartAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_depart)]
    Task ISaleClient.PostSaleDeliveryRetailerDepartAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerDepartRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerDepartAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_restock)]
    Task ISaleClient.PostSaleDeliveryRetailerRestockAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRestockRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerRestockAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_restock)]
    Task ISaleClient.PostSaleDeliveryRetailerRestockAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerRestockRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerRestockAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_sale)]
    Task ISaleClient.PostSaleDeliveryRetailerSaleAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerSaleRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerSaleAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_sale)]
    Task ISaleClient.PostSaleDeliveryRetailerSaleAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerSaleRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerSaleAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_end)]
    Task ISaleClient.PostSaleDeliveryRetailerEndAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerEndRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerEndAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries_retailer_end)]
    Task ISaleClient.PostSaleDeliveryRetailerEndAsync(string licenseNumber,
        IEnumerable<PostSaleDeliveryRetailerEndRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleDeliveryRetailerEndAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_counties)]
    Task<ICollection<County>?> ISaleClient.GetSaleCountiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<County>?>(new List<County>())
            : SaleClient.GetSaleCountiesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v1_counties)]
    Task<ICollection<County>?> ISaleClient.GetSaleCountiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<County>?>(new List<County>())
            : SaleClient.GetSaleCountiesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_paymenttypes)]
    Task<ICollection<string>> ISaleClient.GetSalePaymentTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : SaleClient.GetSalePaymentTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_paymenttypes)]
    Task<ICollection<string>> ISaleClient.GetSalePaymentTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<string>>(new List<string>())
            : SaleClient.GetSalePaymentTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub)]
    Task ISaleClient.PutSaleDeliveryHubAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub)]
    Task ISaleClient.PutSaleDeliveryHubAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_accept)]
    Task ISaleClient.PutSaleDeliveryHubAcceptAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubAcceptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAcceptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_hub_accept)]
    Task ISaleClient.PutSaleDeliveryHubAcceptAsync(string licenseNumber, IEnumerable<PutSaleDeliveryHubAcceptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleDeliveryHubAcceptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_returnreasons)]
    Task<ICollection<DeliveryReturnReason>?> ISaleClient.GetSaleDeliveryReturnReasonsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<DeliveryReturnReason>?>(new List<DeliveryReturnReason>())
            : SaleClient.GetSaleDeliveryReturnReasonsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_returnreasons)]
    Task<ICollection<DeliveryReturnReason>?> ISaleClient.GetSaleDeliveryReturnReasonsAsync(
        string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<DeliveryReturnReason>?>(new List<DeliveryReturnReason>())
            : SaleClient.GetSaleDeliveryReturnReasonsAsync(licenseNumber, cancellationToken);
    
    [MapsToApi(MetrcEndpoint.get_sales_v1_patientregistration_locations)]
    Task<ICollection<PatientRegistrationLocation>?> ISaleClient.GetSalePatientRegistrationLocationsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientRegistrationLocation>?>(new List<PatientRegistrationLocation>())
            : SaleClient.GetSalePatientRegistrationLocationsAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v1_patientregistration_locations)]
    Task<ICollection<PatientRegistrationLocation>?> ISaleClient.GetSalePatientRegistrationLocationsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<PatientRegistrationLocation>?>(new List<PatientRegistrationLocation>())
            : SaleClient.GetSalePatientRegistrationLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_id)]
    Task ISaleClient.DeleteSaleDeliveryByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_deliveries_id)]
    Task ISaleClient.DeleteSaleDeliveryByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleDeliveryByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetSaleReceiptActiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetSaleReceiptActiveAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetSaleReceiptActiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetSaleReceiptActiveAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetSaleReceiptInactiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetSaleReceiptInactiveAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    Task<ICollection<SaleReceipt>?> ISaleClient.GetSaleReceiptInactiveAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleReceipt>?>(new List<SaleReceipt>())
            : SaleClient.GetSaleReceiptInactiveAsync(licenseNumber, salesDateStart, salesDateEnd,
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
    Task ISaleClient.PostSaleReceiptsAsync(string licenseNumber, IEnumerable<PostSaleReceiptsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleReceiptsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    Task ISaleClient.PostSaleReceiptsAsync(string licenseNumber, IEnumerable<PostSaleReceiptsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleReceiptsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleClient.PutSaleReceiptsAsync(string licenseNumber, IEnumerable<PutSaleReceiptsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptsAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    Task ISaleClient.PutSaleReceiptsAsync(string licenseNumber, IEnumerable<PutSaleReceiptsRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleReceiptsAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleClient.DeleteSaleReceiptByIdAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleReceiptByIdAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    Task ISaleClient.DeleteSaleReceiptByIdAsync(long id, string licenseNumber, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteSaleReceiptByIdAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>?> ISaleClient.GetSaleTransactionsAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>?>(new List<SaleTransactionSummary>())
            : SaleClient.GetSaleTransactionsAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    Task<ICollection<SaleTransactionSummary>?> ISaleClient.GetSaleTransactionsAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransactionSummary>?>(new List<SaleTransactionSummary>())
            : SaleClient.GetSaleTransactionsAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>?> ISaleClient.GetSaleTransactionByDateRangeAsync(
        DateTime salesDateStart, DateTime salesDateEnd, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>?>(new List<SaleTransaction>())
            : SaleClient.GetSaleTransactionByDateRangeAsync(salesDateStart, salesDateEnd, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    Task<ICollection<SaleTransaction>?> ISaleClient.GetSaleTransactionByDateRangeAsync(
        DateTime salesDateStart, DateTime salesDateEnd, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<SaleTransaction>?>(new List<SaleTransaction>())
            : SaleClient.GetSaleTransactionByDateRangeAsync(salesDateStart, salesDateEnd,
                licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleClient.PostSaleTransactionsAsync(DateTime date, string licenseNumber,
        IEnumerable<PostSaleTransactionsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleTransactionsAsync(date, licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    Task ISaleClient.PostSaleTransactionsAsync(DateTime date, string licenseNumber,
        IEnumerable<PostSaleTransactionsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PostSaleTransactionsAsync(date, licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleClient.PutSaleTransactionsAsync(DateTime date, string licenseNumber,
        IEnumerable<PutSaleTransactionsRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleTransactionsAsync(date, licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    Task ISaleClient.PutSaleTransactionsAsync(DateTime date, string licenseNumber,
        IEnumerable<PutSaleTransactionsRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.PutSaleTransactionsAsync(date, licenseNumber, body, cancellationToken);
}