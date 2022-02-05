namespace OpenMetrc.Builder.Models.Requests;

public class RemoveWasteRequest
{
    public RemoveWasteRequest()
    {
        WasteType = string.Empty;
        UnitOfWeight = string.Empty;
    }

    public int Id { get; set; }
    public string WasteType { get; set; }
    public string UnitOfWeight { get; set; }
    public double WasteWeight { get; set; }
    public DateTime ActualDate { get; set; }
}