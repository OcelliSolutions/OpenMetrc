namespace OpenMetrc.Builder.Models;

public class Strain
{
    [Required]
    public int Id { get; set; }
    [MaxLength(100)] public string? Name { get; set; }
    [MaxLength(100)] public string? TestingStatus { get; set; }
    public double? ThcLevel { get; set; }
    public double? CbdLevel { get; set; }
    public double IndicaPercentage { get; set; }
    public double SativaPercentage { get; set; }
    public bool IsUsed { get; set; }
    public string? Genetics { get; set; }
}