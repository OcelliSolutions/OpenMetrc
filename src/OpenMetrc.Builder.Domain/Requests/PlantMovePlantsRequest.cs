namespace OpenMetrc.Builder.Domain.Requests;

public class PlantMovePlantsRequest
{
    public PlantMovePlantsRequest()
    {
        Location = string.Empty;
    }

    public int? Id { get; set; }
    public string? Label { get; set; }
    public string Location { get; set; }
    public DateTime ActualDate { get; set; }
}