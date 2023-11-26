namespace OpenMetrc.Builder.Domain.Requests;

public class UpdateTransferRequest : CreateTransferRequest
{
    public long TransferId { get; set; }
}