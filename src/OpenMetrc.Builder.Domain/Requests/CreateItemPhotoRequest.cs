namespace OpenMetrc.Builder.Domain.Requests;

public class CreateItemPhotoRequest
{
    [Required] public string? FileName { get; set; }
    [Required] public string? EncodedImageBase64 { get; set; }
}