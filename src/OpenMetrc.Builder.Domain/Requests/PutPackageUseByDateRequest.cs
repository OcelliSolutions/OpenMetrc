namespace OpenMetrc.Builder.Domain.Requests;
public class PutPackageUseByDateRequest
{
    public string? Label { get; set; }
    public DateOnly? ExpirationDate { get; set; }
    public DateOnly? SellByDate { get; set; }
    public DateOnly? UseByDate { get; set; }
}
