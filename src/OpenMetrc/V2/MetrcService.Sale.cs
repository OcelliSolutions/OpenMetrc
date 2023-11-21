using System.Threading;

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
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetActiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetActiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_active)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetActiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetActiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_inactive)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetInactiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetInactiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_inactive)]
    Task<SaleDeliveryMetrcWrapper> ISaleClient.GetInactiveSaleDeliveriesAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleDeliveryMetrcWrapper())
            : SaleClient.GetInactiveSaleDeliveriesAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd, cancellationToken);

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
    Task ISaleClient.CreateSaleDeliveryAsync(string licenseNumber, IEnumerable<CreateSaleDeliveryRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleDeliveryAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries)]
    Task ISaleClient.CreateSaleDeliveryAsync(string licenseNumber, IEnumerable<CreateSaleDeliveryRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleDeliveryAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries)]
    Task ISaleClient.UpdateSaleDeliveryAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries)]
    Task ISaleClient.UpdateSaleDeliveryAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_complete)]
    Task ISaleClient.UpdateSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<UpdateSaleDeliveryCompleteRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryCompleteAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_complete)]
    Task ISaleClient.UpdateSaleDeliveryCompleteAsync(string licenseNumber,
        IEnumerable<UpdateSaleDeliveryCompleteRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryCompleteAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_depart)]
    Task ISaleClient.DepartSaleDeliveryHubAsync(string licenseNumber, IEnumerable<DepartSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DepartSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_depart)]
    Task ISaleClient.DepartSaleDeliveryHubAsync(string licenseNumber, IEnumerable<DepartSaleDeliveryHubRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DepartSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID)]
    Task ISaleClient.VerifyIdSaleDeliveryHubAsync(string licenseNumber,
        IEnumerable<VerifyIdSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.VerifyIdSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID)]
    Task ISaleClient.VerifyIdSaleDeliveryHubAsync(string licenseNumber,
        IEnumerable<VerifyIdSaleDeliveryHubRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.VerifyIdSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_finalize)]
    Task ISaleClient.FinalizeSaleReceiptAsync(string licenseNumber, IEnumerable<FinalizeSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.FinalizeSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_finalize)]
    Task ISaleClient.FinalizeSaleReceiptAsync(string licenseNumber, IEnumerable<FinalizeSaleReceiptRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.FinalizeSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_unfinalize)]
    Task ISaleClient.UnfinalizeSaleReceiptAsync(string licenseNumber, IEnumerable<FinalizeSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UnfinalizeSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts_unfinalize)]
    Task ISaleClient.UnfinalizeSaleReceiptAsync(string licenseNumber, IEnumerable<FinalizeSaleReceiptRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UnfinalizeSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_active)]
    Task<RetailerMetrcWrapper> ISaleClient.GetDeliveriesRetailerActiveAsync(string licenseNumber,
        DateTime lastModifiedStart, DateTime lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetDeliveriesRetailerActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_active)]
    Task<RetailerMetrcWrapper> ISaleClient.GetDeliveriesRetailerActiveAsync(string licenseNumber,
        DateTime lastModifiedStart, DateTime lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetDeliveriesRetailerActiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive)]
    Task<RetailerMetrcWrapper> ISaleClient.GetDeliveriesRetailerInactiveAsync(string licenseNumber,
        DateTime lastModifiedStart, DateTime lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetDeliveriesRetailerInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive)]
    Task<RetailerMetrcWrapper> ISaleClient.GetDeliveriesRetailerInactiveAsync(string licenseNumber,
        DateTime lastModifiedStart, DateTime lastModifiedEnd,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new RetailerMetrcWrapper())
            : SaleClient.GetDeliveriesRetailerInactiveAsync(licenseNumber, lastModifiedStart, lastModifiedEnd,
                cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetDeliveriesRetailerAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetDeliveriesRetailerAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_retailer_id)]
    Task<Retailer> ISaleClient.GetDeliveriesRetailerAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new Retailer())
            : SaleClient.GetDeliveriesRetailerAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_retailer_id)]
    Task ISaleClient.DeleteDeliveriesRetailerAsync(long id, string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveriesRetailerAsync(id, licenseNumber);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_retailer_id)]
    Task ISaleClient.DeleteDeliveriesRetailerAsync(long id, string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveriesRetailerAsync(id, licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer)]
    Task ISaleClient.CreateDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<CreateSalesDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateDeliveriesRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer)]
    Task ISaleClient.CreateDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<CreateSalesDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateDeliveriesRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_retailer)]
    Task ISaleClient.UpdateDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateDeliveriesRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_retailer)]
    Task ISaleClient.UpdateDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateDeliveriesRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_depart)]
    Task ISaleClient.DepartDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerDepartRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DepartDeliveriesRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_depart)]
    Task ISaleClient.DepartDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerDepartRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DepartDeliveriesRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_restock)]
    Task ISaleClient.RestockDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerRestockRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.RestockDeliveriesRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_restock)]
    Task ISaleClient.RestockDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerRestockRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.RestockDeliveriesRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_sale)]
    Task ISaleClient.CreateDeliveriesRetailerSaleAsync(string licenseNumber,
        IEnumerable<CreateSalesDeliveryRetailerSaleRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateDeliveriesRetailerSaleAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_sale)]
    Task ISaleClient.CreateDeliveriesRetailerSaleAsync(string licenseNumber,
        IEnumerable<CreateSalesDeliveryRetailerSaleRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateDeliveriesRetailerSaleAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_end)]
    Task ISaleClient.EndDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerEndRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.EndDeliveriesRetailerAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_deliveries_retailer_end)]
    Task ISaleClient.EndDeliveriesRetailerAsync(string licenseNumber,
        IEnumerable<UpdateSalesDeliveryRetailerEndRequest> body, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.EndDeliveriesRetailerAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_counties)]
    Task<CountyMetrcWrapper> ISaleClient.GetCountiesAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CountyMetrcWrapper())
            : SaleClient.GetCountiesAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_counties)]
    Task<CountyMetrcWrapper> ISaleClient.GetCountiesAsync(CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new CountyMetrcWrapper())
            : SaleClient.GetCountiesAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_paymenttypes)]
    Task<StringMetrcWrapper> ISaleClient.GetPaymentTypesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetPaymentTypesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_sales_v2_paymenttypes)]
    Task<StringMetrcWrapper> ISaleClient.GetPaymentTypesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new StringMetrcWrapper())
            : SaleClient.GetPaymentTypesAsync(licenseNumber, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub)]
    Task ISaleClient.UpdateSaleDeliveryHubAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub)]
    Task ISaleClient.UpdateSaleDeliveryHubAsync(string licenseNumber, IEnumerable<UpdateSaleDeliveryHubRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_accept)]
    Task ISaleClient.AcceptSaleDeliveryHubAsync(string licenseNumber, IEnumerable<AcceptSaleDeliveryHubRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.AcceptSaleDeliveryHubAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_deliveries_hub_accept)]
    Task ISaleClient.AcceptSaleDeliveryHubAsync(string licenseNumber, IEnumerable<AcceptSaleDeliveryHubRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.AcceptSaleDeliveryHubAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_returnreasons)]
    Task<DeliveryReturnReasonMetrcWrapper> ISaleClient.GetDeliveryReturnReasonsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new DeliveryReturnReasonMetrcWrapper())
            : SaleClient.GetDeliveryReturnReasonsAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_deliveries_returnreasons)]
    Task<DeliveryReturnReasonMetrcWrapper> ISaleClient.GetDeliveryReturnReasonsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new DeliveryReturnReasonMetrcWrapper())
            : SaleClient.GetDeliveryReturnReasonsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_patientregistration_locations)]
    Task<PatientRegistrationLocationMetrcWrapper> ISaleClient.GetPatientRegistrationLocationsAsync() =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientRegistrationLocationMetrcWrapper())
            : SaleClient.GetPatientRegistrationLocationsAsync();

    [MapsToApi(MetrcEndpoint.get_sales_v2_patientregistration_locations)]
    Task<PatientRegistrationLocationMetrcWrapper> ISaleClient.GetPatientRegistrationLocationsAsync(
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new PatientRegistrationLocationMetrcWrapper())
            : SaleClient.GetPatientRegistrationLocationsAsync(cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_id)]
    Task ISaleClient.DeleteDeliveryAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveryAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_deliveries_id)]
    Task ISaleClient.DeleteDeliveryAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteDeliveryAsync(licenseNumber, id, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_active)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_active)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetActiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetActiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd, lastModifiedStart,
                lastModifiedEnd, cancellationToken);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_inactive)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetInactiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd,
                lastModifiedStart,
                lastModifiedEnd);

    [MapsToApi(MetrcEndpoint.get_sales_v2_receipts_inactive)]
    Task<SaleReceiptMetrcWrapper> ISaleClient.GetInactiveSaleReceiptsAsync(string licenseNumber,
        DateTimeOffset? salesDateStart, DateTimeOffset? salesDateEnd, DateTimeOffset? lastModifiedStart,
        DateTimeOffset? lastModifiedEnd, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new SaleReceiptMetrcWrapper())
            : SaleClient.GetInactiveSaleReceiptsAsync(licenseNumber, salesDateStart, salesDateEnd,
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
    Task ISaleClient.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.post_sales_v2_receipts)]
    Task ISaleClient.CreateSaleReceiptAsync(string licenseNumber, IEnumerable<CreateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.CreateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts)]
    Task ISaleClient.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleReceiptAsync(licenseNumber, body);

    [MapsToApi(MetrcEndpoint.put_sales_v2_receipts)]
    Task ISaleClient.UpdateSaleReceiptAsync(string licenseNumber, IEnumerable<UpdateSaleReceiptRequest> body,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.UpdateSaleReceiptAsync(licenseNumber, body, cancellationToken);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_receipts_id)]
    Task ISaleClient.DeleteReceiptAsync(string licenseNumber, long id) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteReceiptAsync(licenseNumber, id);

    [MapsToApi(MetrcEndpoint.delete_sales_v2_receipts_id)]
    Task ISaleClient.DeleteReceiptAsync(string licenseNumber, long id, CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.CompletedTask
            : SaleClient.DeleteReceiptAsync(licenseNumber, id, cancellationToken);
}