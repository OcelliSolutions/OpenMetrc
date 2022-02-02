namespace OpenMetrc.Builder.Models.Requests;

public class UpdateLocationRequest
{
    public UpdateLocationRequest()
    {
        Name = string.Empty;
        LocationTypeName = string.Empty;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LocationTypeName { get; set; }
}