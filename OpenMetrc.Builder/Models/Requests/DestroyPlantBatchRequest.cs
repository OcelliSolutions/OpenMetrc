namespace OpenMetrc.Builder.Models.Requests;

public class DestroyPlantBatchRequest
{
    public DestroyPlantBatchRequest()
    {
        PlantBatch = string.Empty;
        ReasonNote = string.Empty;
    }
    public string PlantBatch { get; set; }
    public int Count { get; set; }
    public string ReasonNote { get; set; }
    public DateTime ActualDate { get; set; }
}
