using System.Data;
using System.Text.RegularExpressions;

namespace OpenMetrc.ClientGenerator;

internal static partial class FileService
{
    internal static string GetVersionFromFilename(string filename)
    {
        var match = FileVersion().Match(filename);
        if (!match.Success) throw new InvalidExpressionException("Unable to get version from filename");
        var version = match.Groups[1].Value;
        return version;
    }

    [GeneratedRegex(@"(v\d+)")]
    private static partial Regex FileVersion();
}