using HtmlAgilityPack;
using OpenMetrc.Scraper.Models;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace OpenMetrc.Scraper;
internal static class StateService
{
    // This ensures that any states that have gone offline or have removed endpoints are taken care of
    internal static void DeleteReferenceDocuments()
    {
        // Ensure the directory exists
        Directory.Delete("../../../Reference", true);
    }

    internal static async Task<StateSummary> ProcessState(string state)
    {
        var stateSummary = new StateSummary(state);
        var content = await GetApiContentAsync(state);
        if (content == null) return stateSummary;

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(content);

        var regex = new Regex("(?:[^a-z0-9_-]|(?<=['\"])s)",
            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        var versions = new List<string>() { "version-1-collapse", "version-2-collapse" };

        await ProcessHtmlDocumentAsync(htmlDoc, versions, regex, stateSummary);
        return stateSummary;
    }

    internal static async Task WriteStateSummary(List<StateSummary> stateSummaries)
    {
        const string path = "../../../../../state-summaries.json";
        await File.WriteAllTextAsync(path, FormatJsonText(JsonSerializer.Serialize(stateSummaries.OrderBy(s => s.State))));

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@$"A summary of all METRC states has been written to: {path}");
    }

    private static async Task WriteEndpointDocument(string state, string section, string endpoint, string? content)
    {
        if (string.IsNullOrWhiteSpace(content))
            return;

        var directoryPath = Path.Combine("../../../Reference", section, state);
        var filePath = Path.Combine(directoryPath, $"{endpoint}.html");

        // Ensure the directory exists
        Directory.CreateDirectory(directoryPath);

        // Write the file
        await File.WriteAllTextAsync(filePath, content);
    }


    private static async Task ProcessHtmlDocumentAsync(HtmlDocument htmlDoc, List<string> versions, Regex regex, StateSummary stateSummary)
    {
        foreach (var version in versions)
        {
            var doc = htmlDoc.GetElementbyId(version);
            if (doc == null) continue;

            foreach (var link in doc.Descendants("a"))
            {
                await ProcessLinkAsync(link, regex, stateSummary);
            }
        }
    }

    private static async Task ProcessLinkAsync(HtmlNode link, Regex regex, StateSummary stateSummary)
    {
        var hrefValue = link.GetAttributeValue("href", string.Empty);
        var split = hrefValue.Split(new[] { '.' });
        if (split.Length != 3) return;

        var sectionName = split[0].Replace("#", "");
        var endpoint = regex.Replace(split[1], string.Empty).TrimEnd('_');

        var section = stateSummary.Sections.FirstOrDefault(s => s.Name == sectionName)
            ?? new Section(sectionName);

        if (!stateSummary.Sections.Contains(section))
        {
            stateSummary.Sections.Add(section);
        }

        section.Endpoints.Add(endpoint);
        var endpointContent = await GetEndpointContentAsync(stateSummary.State, sectionName, $"{split[1]}.{split[2]}");
        await WriteEndpointDocument(stateSummary.State, sectionName, endpoint, endpointContent);
    }

    private static async Task<string?> GetApiContentAsync(string state)
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
        var url = $@"https://api-{state}.metrc.com/documentation";
        try
        {
            return await client.GetStringAsync(url);
        }
        catch (HttpRequestException)
        {
            return null;
        }
        catch (TaskCanceledException)
        {
            return null;
        }
    }

    private static async Task<string?> GetEndpointContentAsync(string state, string section, string key)
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
        var url = $@"https://api-{state}.metrc.com/Documentation/Method?key={section}.{key}";
        try
        {
            return await client.GetStringAsync(url);
        }
        catch (HttpRequestException)
        {
            return null;
        }
        catch (TaskCanceledException)
        {
            return null;
        }
    }

    private static string FormatJsonText(string jsonString)
    {
        using var doc = JsonDocument.Parse(jsonString);
        using var memoryStream = new MemoryStream();
        using (var utf8JsonWriter = new Utf8JsonWriter(memoryStream, new JsonWriterOptions { Indented = true }))
        {
            doc.WriteTo(utf8JsonWriter);
        }

        return Encoding.UTF8.GetString(memoryStream.ToArray());
    }
}
