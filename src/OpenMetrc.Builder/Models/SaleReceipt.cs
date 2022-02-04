namespace OpenMetrc.Builder.Models;

public class SaleReceipt
{
    [Required] public int Id { get; set; }

    [MaxLength(100)] public string? ReceiptNumber { get; set; }
    public DateTimeOffset SalesDateTime { get; set; }
    [MaxLength(100)] public string? SalesCustomerType { get; set; }
    [MaxLength(100)] public string? PatientLicenseNumber { get; set; }
    [MaxLength(100)] public string? CaregiverLicenseNumber { get; set; }
    [MaxLength(100)] public string? IdentificationMethod { get; set; }
    public int TotalPackages { get; set; }
    public double TotalPrice { get; set; }
    public ICollection<SaleReceiptTransaction>? Transactions { get; set; }
    public bool IsFinal { get; set; }
    public DateTimeOffset? ArchivedDate { get; set; }
    public DateTimeOffset RecordedDateTime { get; set; }
    [MaxLength(100)] public string? RecordedByUserName { get; set; }
    public DateTimeOffset LastModified { get; set; }
}