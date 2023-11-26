namespace OpenMetrc.Builder.Domain.Requests;

public class PackageChangeLocationsRequest
{
    public PackageChangeLocationsRequest()
    {
        Label = string.Empty;
        Location = string.Empty;
    }

    public string Label { get; set; }
    public string Location { get; set; }
    public DateTime MoveDate { get; set; }
}