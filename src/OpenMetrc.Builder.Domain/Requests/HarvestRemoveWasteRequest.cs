namespace OpenMetrc.Builder.Domain.Requests;

public class HarvestRemoveWasteRequest
{
    public HarvestRemoveWasteRequest()
    {
        WasteType = string.Empty;
        UnitOfWeight = string.Empty;
    }

    public long Id { get; set; }
    public string WasteType { get; set; }
    public string UnitOfWeight { get; set; }
    public double WasteWeight { get; set; }
    public DateTime ActualDate { get; set; }
}