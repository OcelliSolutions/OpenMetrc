namespace OpenMetrc.Builder.Domain.Requests;

public class DeletePlantBatchesRequest
{
    public DeletePlantBatchesRequest()
    {
        PlantBatch = string.Empty;
        ReasonNote = string.Empty;
    }

    public string PlantBatch { get; set; }
    public int Count { get; set; }
    public string ReasonNote { get; set; }
    public DateTime ActualDate { get; set; }
}