namespace OpenMetrc.Builder.Domain;

public class UnitOfMeasure
{
    public UnitOfMeasure()
    {
        Name = string.Empty;
        QuantityType = string.Empty;
        Abbreviation = string.Empty;
    }

    [Required] public string Name { get; set; }

    public string QuantityType { get; set; }
    public string Abbreviation { get; set; }
}