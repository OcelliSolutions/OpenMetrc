namespace OpenMetrc.Builder.Models.Requests;

public class CreatePhotoRequest
{
    [Required] public string? FileName { get; set; }
    [Required] public string? EncodedImageBase64 { get; set; }
}
