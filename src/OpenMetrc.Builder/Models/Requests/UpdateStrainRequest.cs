namespace OpenMetrc.Builder.Models.Requests;

public class UpdateStrainRequest
{
    public UpdateStrainRequest()
    {
        Name = string.Empty;
        TestingStatus = string.Empty;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string TestingStatus { get; set; }
    public double ThcLevel { get; set; }
    public double CbdLevel { get; set; }
    public double IndicaPercentage { get; set; }
    public double SativaPercentage { get; set; }
}