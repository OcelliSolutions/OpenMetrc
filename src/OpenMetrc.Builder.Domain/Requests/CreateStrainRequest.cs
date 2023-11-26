namespace OpenMetrc.Builder.Domain.Requests;

public class CreateStrainRequest
{
    public CreateStrainRequest()
    {
        Name = string.Empty;
        TestingStatus = string.Empty;
    }

    public string Name { get; set; }
    public string TestingStatus { get; set; }
    public double ThcLevel { get; set; }
    public double CbdLevel { get; set; }
    public double IndicaPercentage { get; set; }
    public double SativaPercentage { get; set; }
}