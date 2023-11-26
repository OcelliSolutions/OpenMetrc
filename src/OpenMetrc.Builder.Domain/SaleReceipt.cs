namespace OpenMetrc.Builder.Domain;

public class SaleReceipt
{
    [Required] public long Id { get; set; }

    public string? ReceiptNumber { get; set; }
    public DateTimeOffset SalesDateTime { get; set; }
    public string? SalesCustomerType { get; set; }
    public string? PatientLicenseNumber { get; set; }
    public string? CaregiverLicenseNumber { get; set; }
    public string? IdentificationMethod { get; set; }
    public int TotalPackages { get; set; }
    public double TotalPrice { get; set; }
    public ICollection<SaleReceiptTransaction>? Transactions { get; set; }
    public bool IsFinal { get; set; }
    public DateTimeOffset? ArchivedDate { get; set; }
    public DateTimeOffset RecordedDateTime { get; set; }
    public string? RecordedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
}