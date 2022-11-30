namespace OpenMetrc.Builder.Controllers.V1;

[Route("sales/v1")]
[ApiController]
public class SaleController : ControllerBase
{
    [HttpGet("customertypes")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_customertypes)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get sale customer types")]
    public ActionResult GetSaleCustomerTypes() => Ok();

    [HttpGet("receipts/active")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleReceipt>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active sales receipts")]
    public ActionResult GetActiveSaleReceipts(
        [Required] string licenseNumber,
        [SwaggerParameter(
            "The sales date start timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateStart,
        [SwaggerParameter(
            "The sales date end timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateEnd,
        [SwaggerParameter(
            "The last modified start timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter(
            "The last modified end timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("receipts/inactive")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleReceipt>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive sales receipts")]
    public ActionResult GetInactiveSaleReceipts(
        [Required] string licenseNumber,
        [SwaggerParameter(
            "The sales date start timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateStart,
        [SwaggerParameter(
            "The sales date end timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateEnd,
        [SwaggerParameter(
            "The last modified start timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter(
            "The last modified end timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("receipts/{id:long}")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_receipts_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(SaleReceipt), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a sales receipt by id")]
    public ActionResult GetSaleReceiptById(
        [Required] [SwaggerParameter(Description = "Receipt ID")]
        long id,
        [SwaggerParameter("If specified, the Sales Receipt will be validated against the specified License Number. " +
                          "If not specified, the Sales Receipt will be validated against all of the User's current Facilities. " +
                          "Please note that if the Sales Receipt is not valid for the specified License Number, a 401 Unauthorized status will be returned")]
        string licenseNumber
    ) => Ok();

    [HttpPost("receipts")]
    [MapsToApi(MetrcEndpoint.post_sales_v1_receipts)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Create a new sale receipt",
        Description =
            "Please note: The SalesDateTime field must be the actual date and time of the transaction without time zone. " +
            "This date/time must already be in the same time zone as the Facility recording the sales. " +
            "For example, if the Facility is in Pacific Time, then this time must be Pacific Standard (or Daylight Savings) Time and not in UTC.")]
    public ActionResult CreateSaleReceipt([Required] string licenseNumber,
        [Required] IEnumerable<CreateSaleReceiptRequest> createSaleReceiptRequests) => Ok();

    [HttpPut("receipts")]
    [MapsToApi(MetrcEndpoint.put_sales_v1_receipts)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Create a new sale receipt",
        Description =
            "Please note: The SalesDateTime field must be the actual date and time of the transaction without time zone. " +
            "This date/time must already be in the same time zone as the Facility recording the sales. " +
            "For example, if the Facility is in Pacific Time, then this time must be Pacific Standard (or Daylight Savings) Time and not in UTC.")]
    public ActionResult UpdateSaleReceipt([Required] string licenseNumber,
        [Required] IEnumerable<UpdateSaleReceiptRequest> updateSaleReceiptRequests) => Ok();

    [HttpDelete("{id:long}")]
    [MapsToApi(MetrcEndpoint.delete_sales_v1_receipts_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Delete an sale receipt")]
    public ActionResult DeleteReceipt([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Sale Receipt ID")]
        long id) => Ok();

    [HttpGet("transactions")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleTransactionSummary>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a summary of all sales")]
    public ActionResult GetTransactions(
        [Required]
        [SwaggerParameter(
            "The license number of the facility for which to return the list of dates with sales transactions")]
        string licenseNumber) => Ok();

    [HttpGet("transactions/{salesDateStart}/{salesDateEnd}")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleTransaction>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a detail of all sales transactions between a date range")]
    public ActionResult GetTransactionsByDateRange(
        [Required]
        [SwaggerParameter(
            "The license number of the facility for which to return the list of sales transactions for the specified date range")]
        string licenseNumber,
        [Required] DateTime salesDateStart,
        [Required] DateTime salesDateEnd
    ) => Ok();

    [HttpPost("transactions/{date}")]
    [MapsToApi(MetrcEndpoint.post_sales_v1_transactions_date)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Upload a sales summary")]
    public ActionResult CreateSaleTransactionSummary(
        [Required]
        [SwaggerParameter(
            "The license number of the facility for which to append the sales transactions on the specified date")]
        string licenseNumber,
        [Required] DateTime date,
        [Required] IEnumerable<SaleTransactionSummary> saleTransactionSummaries) => Ok();

    [HttpPut("transactions/{date}")]
    [MapsToApi(MetrcEndpoint.put_sales_v1_transactions_date)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Update a sales summary")]
    public ActionResult UpdateSaleTransactionSummary(
        [Required]
        [SwaggerParameter(
            "The license number of the facility for which to update the sales transactions on the specified date")]
        string licenseNumber,
        [Required] DateTime date,
        [Required] IEnumerable<SaleTransactionSummary> saleTransactionSummaries) => Ok();


    [HttpGet("deliveries/active")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_active)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get active sales deliveries")]
    public ActionResult GetActiveSaleDeliveries(
        [Required] string licenseNumber,
        [SwaggerParameter(
            "The sales date start timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateStart,
        [SwaggerParameter(
            "The sales date end timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateEnd,
        [SwaggerParameter(
            "The last modified start timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter(
            "The last modified end timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("deliveries/inactive")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_deliveries_inactive)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(IEnumerable<SaleDelivery>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get inactive sales deliveries")]
    public ActionResult GetInactiveSaleDeliveries(
        [Required] string licenseNumber,
        [SwaggerParameter(
            "The sales date start timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateStart,
        [SwaggerParameter(
            "The sales date end timestamp. If specified, also specifying any of the last modified parameters will result in an error.")]
        DateTimeOffset? salesDateEnd,
        [SwaggerParameter(
            "The last modified start timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedStart,
        [SwaggerParameter(
            "The last modified end timestamp. If specified, also specifying any of the sales date parameters will result in an error.")]
        DateTimeOffset? lastModifiedEnd
    ) => Ok();

    [HttpGet("delivery/{id:long}")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [ProducesResponseType(typeof(SaleDelivery), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get a sales delivery by id")]
    public ActionResult GetSaleDeliveryById(
        [Required] [SwaggerParameter(Description = "Delivery ID")]
        long id,
        [SwaggerParameter("If specified, the Sales Delivery will be validated against the specified License Number. " +
                          "If not specified, the Sales Delivery will be validated against all of the User's current Facilities. " +
                          "Please note that if the Sales Delivery is not valid for the specified License Number, a 401 Unauthorized status will be returned")]
        string licenseNumber
    ) => Ok();

    [HttpPost("deliveries")]
    [MapsToApi(MetrcEndpoint.post_sales_v1_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Create a new sale delivery",
        Description =
            "Please note: The SalesDateTime field must be the actual date and time of the transaction without time zone. " +
            "This date/time must already be in the same time zone as the Facility recording the sales. " +
            "For example, if the Facility is in Pacific Time, then this time must be Pacific Standard (or Daylight Savings) Time and not in UTC.")]
    public ActionResult CreateSaleDelivery([Required] string licenseNumber,
        [Required] IEnumerable<CreateSaleDeliveryRequest> createSaleDeliveryRequests) => Ok();

    [HttpPut("deliveries")]
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Create a new sale delivery",
        Description =
            "Please note: The SalesDateTime field must be the actual date and time of the transaction without time zone. " +
            "This date/time must already be in the same time zone as the Facility recording the sales. " +
            "For example, if the Facility is in Pacific Time, then this time must be Pacific Standard (or Daylight Savings) Time and not in UTC.")]
    public ActionResult UpdateSaleDelivery([Required] string licenseNumber,
        [Required] IEnumerable<UpdateSaleDeliveryRequest> updateSaleDeliveryRequests) => Ok();

    [HttpDelete("delivery/{id:long}")]
    [MapsToApi(MetrcEndpoint.delete_sales_v1_delivery_id)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Delete an sale delivery")]
    public ActionResult DeleteDelivery([Required] string licenseNumber,
        [Required] [SwaggerParameter(Description = "Sale Delivery ID")]
        long id) => Ok();


    [HttpPut("deliveries/complete")]
    [MapsToApi(MetrcEndpoint.put_sales_v1_deliveries_complete)]
    [Authorize]
    [ApiAuthorizationFilter(new[] { ApiPermission.Sales })]
    [SwaggerOperation(Summary = "Update a sale delivery to complete",
        Description =
            "Please note: The SalesDateTime field must be the actual date and time of the transaction without time zone. " +
            "This date/time must already be in the same time zone as the Facility recording the sales. " +
            "For example, if the Facility is in Pacific Time, then this time must be Pacific Standard (or Daylight Savings) Time and not in UTC.")]
    public ActionResult UpdateSaleDeliveryComplete([Required] string licenseNumber,
        [Required] IEnumerable<UpdateSaleDeliveryCompleteRequest> updateSaleDeliveryCompleteRequests) => Ok();


    [HttpGet("delivery/returnreasons")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_delivery_returnreasons)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<DeliveryReturnReason>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get delivery return reasons")]
    public ActionResult GetDeliveryReturnReasons() => Ok();

    [HttpGet("patientregistration/locations")]
    [MapsToApi(MetrcEndpoint.get_sales_v1_patientregistration_locations)]
    [Authorize]
    [ApiAuthorizationFilter]
    [ProducesResponseType(typeof(IEnumerable<PatientRegistrationLocation>), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "Get patient registration locations")]
    public ActionResult GetPatientRegistrationLocations() => Ok();
}