namespace OpenMetrc.Builder.Domain.Requests;

public class ProcessingPackageRequest
{
    public string Label { get; set; } = null!;
    public double Quantity { get; set; }
    public string UnitOfMeasure { get; set; } = null!;
}