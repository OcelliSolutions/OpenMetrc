namespace OpenMetrc.Builder.Domain.Requests;

public class PutPlantSplitRequest : PlantSplitRequest
{

}
public class PlantSplitRequest
{
    public DateOnly SplitDate { get; set; }
    public string SourcePlantLabel { get; set; } = null!;
    public int PlantCount { get; set; }
    public string TagLabel { get; set; } = null!;
    public string StrainLabel { get; set; } = null!;
}
