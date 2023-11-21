using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenMetrc.Scraper.Models;

namespace OpenMetrc.Scraper;
internal static class StateService
{
    internal static async Task<StateSummary> ProcessState(string state)
    {
        var stateSummary = new StateSummary(state);
        var content = await ApiContentAsync(state);
        if (content == null) return stateSummary;

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(content);
        var r = new Regex("(?:[^a-z0-9_]|(?<=['\"])s)",
            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        var versions = new List<string>() { "version-1-collapse", "version-2-collapse" };
        foreach (var version in versions)
        {
            var doc = htmlDoc.GetElementbyId(version);
            if (doc == null)
                continue;

            foreach (var link in doc.Descendants("a"))
            {
                var hrefValue = link.GetAttributeValue("href", string.Empty);
                var split = hrefValue.Split(new[] { '.' });
                if (split.Length != 3) continue;
                var sectionName = split[0].Replace("#", "");
                var endpoint = r.Replace(split[1], string.Empty);
                endpoint = endpoint.TrimEnd('_');
                var section = stateSummary.Sections.FirstOrDefault(s => s.Name == sectionName);
                if (section == null)
                {
                    section = new Section(sectionName);
                    stateSummary.Sections.Add(section);
                }

                section.Endpoints.Add(endpoint);
            }
        }

        return stateSummary;
    }

    internal static async Task WriteStateSummary(List<StateSummary> stateSummaries)
    {
        var json = JsonSerializer.Serialize(stateSummaries);
        const string path = "../../../../../state-summaries.json";
        await File.WriteAllTextAsync(path, FormatJsonText(json));

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@$"A summary of all METRC states has been written to: {path}");
    }

    private static async Task<string?> ApiContentAsync(string state)
    {
        var client = new HttpClient { Timeout = new TimeSpan(0, 0, 0, 10) };
        try
        {
            var url = $@"https://api-{state}.metrc.com/documentation";
            var response = await client.GetStringAsync(url);
            return response;
        }
        catch (HttpRequestException)
        {
            // many of these sites do not exist.
            return null;
        }
        catch (TaskCanceledException)
        {
            return null;
        }
    }

    private static string FormatJsonText(string jsonString)
    {
        using var doc = JsonDocument.Parse(
            jsonString,
            new JsonDocumentOptions
            {
                AllowTrailingCommas = true
            }
        );
        var memoryStream = new MemoryStream();
        using (
            var utf8JsonWriter = new Utf8JsonWriter(
                memoryStream,
                new JsonWriterOptions
                {
                    Indented = true
                }
            )
        )
        {
            doc.WriteTo(utf8JsonWriter);
        }

        return new UTF8Encoding()
            .GetString(memoryStream.ToArray());
    }

}
