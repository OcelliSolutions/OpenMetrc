namespace OpenMetrc.Builder.Domain.Requests;
public class PutPlantStrainRequest : PlantStrainRequest
{
}

public class PlantStrainRequest
{
    public long Id { get; set; }
    public string? Label { get; set; }
    public long StrainId { get; set; }
    public string? StrainName { get; set; }
}

public class PutPlantTagRequest : PlantTagRequest
{

}

public class PlantTagRequest
{
    public long? Id { get; set; }
    public string? Group { get; set; }
    public long? TagId { get; set; }
    public string? NewTag { get; set; }
    public DateOnly? ReplaceDate { get; set; }
}
