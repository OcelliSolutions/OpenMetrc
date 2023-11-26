namespace OpenMetrc.Builder.Domain.Requests;
public class PutSaleReceiptFinalizeRequest : SaleReceiptFinalizeRequest
{
}
public class PutSaleReceiptUnfinalizeRequest : SaleReceiptFinalizeRequest
{
}
public class SaleReceiptFinalizeRequest
{
    public long Id { get; set; }
}