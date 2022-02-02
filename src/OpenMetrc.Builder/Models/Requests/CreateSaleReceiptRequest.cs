namespace OpenMetrc.Builder.Models.Requests;

public class CreateSaleReceiptRequest
{
    public CreateSaleReceiptRequest()
    {
        SalesCustomerType = string.Empty;
        Transactions = new List<SaleReceiptTransaction>();
    }

    public DateTimeOffset SalesDateTime { get; set; }
    public string SalesCustomerType { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? CaregiverLicenseNumber { get; set; }
    public string? IdentificationMethod { get; set; }
    public List<SaleReceiptTransaction> Transactions { get; set; }
}