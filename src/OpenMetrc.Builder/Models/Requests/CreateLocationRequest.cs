namespace OpenMetrc.Builder.Models.Requests;

public class CreateLocationRequest
{
    public CreateLocationRequest()
    {
        Name = string.Empty;
        LocationTypeName = string.Empty;
    }

    [Required] public string Name { get; set; }

    [Required] public string LocationTypeName { get; set; }
}