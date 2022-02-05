namespace OpenMetrc.Builder.Models;

public class UnitOfMeasure
{
    public UnitOfMeasure()
    {
        Name = string.Empty;
        QuantityType = string.Empty;
        Abbreviation = string.Empty;
    }

    [Required] [MaxLength(100)] public string Name { get; set; }

    [MaxLength(100)] public string QuantityType { get; set; }
    [MaxLength(100)] public string Abbreviation { get; set; }
}