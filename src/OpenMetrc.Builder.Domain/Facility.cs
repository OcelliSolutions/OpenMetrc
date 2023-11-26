namespace OpenMetrc.Builder.Domain;

public class Facility
{
    public Facility(FacilityType facilityType, License license)
    {
        FacilityType = facilityType;
        License = license;
    }

    [JsonPropertyName("HireDate")] public DateTime? HireDate { get; set; }

    [JsonPropertyName("IsOwner")] public bool IsOwner { get; set; }

    [JsonPropertyName("IsManager")] public bool IsManager { get; set; }

    [JsonPropertyName("Occupations")] public List<object>? Occupations { get; set; }

    [JsonPropertyName("Name")] public string? Name { get; set; }

    [JsonPropertyName("Alias")] public string? Alias { get; set; }

    [JsonPropertyName("DisplayName")] public string? DisplayName { get; set; }

    [JsonPropertyName("CredentialedDate")] public DateTime? CredentialedDate { get; set; }

    [JsonPropertyName("SupportActivationDate")]
    public DateTime? SupportActivationDate { get; set; }

    [JsonPropertyName("SupportExpirationDate")]
    public DateTime? SupportExpirationDate { get; set; }

    [JsonPropertyName("SupportLastPaidDate")]
    public DateTime? SupportLastPaidDate { get; set; }

    [JsonPropertyName("FacilityType")]
    [Required]
    public FacilityType FacilityType { get; set; }

    [JsonPropertyName("License")]
    [Required]
    public License License { get; set; }
}