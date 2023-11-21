namespace OpenMetrc.Builder.Models.Requests;

public class SplitPlantRequest
{
    public DateOnly SplitDate { get; set; }
    public string SourcePlantLabel { get; set; } = null!;
    public int PlantCount { get; set; }
    public string TagLabel { get; set; } = null!;
    public string StrainLabel { get; set; } = null!;
}
