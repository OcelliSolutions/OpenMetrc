namespace OpenMetrc.Builder.Models;

public class Strain
{
    [Required] public long Id { get; set; }

    public string? Name { get; set; }
    public string? TestingStatus { get; set; }
    public double? ThcLevel { get; set; }
    public double? CbdLevel { get; set; }
    public double IndicaPercentage { get; set; }
    public double SativaPercentage { get; set; }
    public bool IsUsed { get; set; }
    public string? Genetics { get; set; }
}