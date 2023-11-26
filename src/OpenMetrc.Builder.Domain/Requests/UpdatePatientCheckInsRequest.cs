namespace OpenMetrc.Builder.Domain.Requests;

public class UpdatePatientCheckInsRequest : CreatePatientCheckInsRequest
{
    public long Id { get; set; }
}