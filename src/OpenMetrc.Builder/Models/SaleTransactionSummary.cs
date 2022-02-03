namespace OpenMetrc.Builder.Models;

public class SaleTransactionSummary
{
    [Required]
    public DateTime SalesDate { get; set; }
    public int? TotalTransactions { get; set; }
    public int? TotalPackages { get; set; }
    public double? TotalPrice { get; set; }
}