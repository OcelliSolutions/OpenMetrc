namespace OpenMetrc.Builder.Domain;

public class PatientRegistrationLocation
{
    [Required] public long Id { get; set; }

    public string? Name { get; set; }
}