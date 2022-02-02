namespace OpenMetrc.Builder.Models.Requests;

public class ChangePackageLocationRequest
{
    public ChangePackageLocationRequest()
    {
        Label = string.Empty;
        Location = string.Empty;
    }

    public string Label { get; set; }
    public string Location { get; set; }
    public DateTime MoveDate { get; set; }
}