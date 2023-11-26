namespace OpenMetrc.Builder.Domain.Requests;

public class PlantBatchMovePlantBatchesRequest
{
    public PlantBatchMovePlantBatchesRequest()
    {
        Name = string.Empty;
        Location = string.Empty;
    }

    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime MoveDate { get; set; }
}