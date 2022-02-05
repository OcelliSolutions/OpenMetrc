namespace OpenMetrc.Builder.Models.Requests;

public class MovePlantRequest
{
    public MovePlantRequest()
    {
        Location = string.Empty;
    }

    public int? Id { get; set; }
    public string? Label { get; set; }
    public string Location { get; set; }
    public DateTime ActualDate { get; set; }
}