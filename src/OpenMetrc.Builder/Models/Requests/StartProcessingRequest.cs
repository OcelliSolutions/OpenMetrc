namespace OpenMetrc.Builder.Models.Requests;

public class StartProcessingRequest
{
    public string JobName { get; set; } = null!;
    public string JobType { get; set; } = null!;
    public string CountUnitOfMeasure { get; set; } = null!;
    public string VolumeUnitOfMeasure { get; set; } = null!;
    public string WeightUnitOfMeasure { get; set; } = null!;
    public List<ProcessingPackageRequest>? Packages { get; set; }
    public DateTime StartDate { get; set; }
}

public class ProcessingPackageRequest
{
    public string Label { get; set; } = null!;
    public double Quantity { get; set; }
    public string UnitOfMeasure { get; set; } = null!;
}
