namespace OpenMetrc.Builder.Domain.Requests;

public class CreatePatientCheckInsRequest
{
    public string? PatientLicenseNumber { get; set; }
    public long CheckInLocationId { get; set; }
    public DateOnly? RegistrationStartDate { get; set; }
    public DateOnly? RegistrationExpiryDate { get; set; }
    public DateOnly? CheckInDate { get; set; }
}