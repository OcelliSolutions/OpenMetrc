namespace OpenMetrc.Builder.Models.Requests;

public class MovePlantBatchRequest
{
    public MovePlantBatchRequest()
    {
        Name = string.Empty;
        Location = string.Empty;
    }
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime MoveDate { get; set; }
}
