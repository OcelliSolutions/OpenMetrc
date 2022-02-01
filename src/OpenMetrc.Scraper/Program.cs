using HtmlAgilityPack;
using System.Text.Json;
using System.Text.RegularExpressions;

var states = new List<string>() { "al", "ak", "az", "ar", "ca", "cz", "co", "ct", "de", "dc", "fl", "ga", "gu", "hi", "id", "il", "in", "ia",
    "ks", "ky", "la", "me", "md", "ma", "mi", "mn", "ms", "mo", "mt", "ne", "nv", "nh", "nj", "nm", "ny", "nc", "nd", "oh", "ok", "or", "pa",
    "pr", "ri", "sc", "sd", "tn", "tx", "ut", "vt", "vi", "va", "wa", "wv", "wi", "wy" };
var stateSummaries = new List<StateSummary>();
var stateCounter = 0.0;
foreach (var state in states)
{
    stateCounter++;
    Console.Write("\rScanning: {0} {1:P}   ", state, stateCounter / states.Count);
    var stateSummary = new StateSummary(state);
    var content = await ApiContentAsync(state);
    if (content == null) continue;

    var htmlDoc = new HtmlDocument();
    htmlDoc.LoadHtml(content);
    var r = new Regex("(?:[^a-z0-9_]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
    foreach (var link in htmlDoc.GetElementbyId("version-1-collapse").Descendants("a"))
    {
        var hrefValue = link.GetAttributeValue("href", string.Empty);
        var split = hrefValue.Split(new[] { '.' });
        if (split.Length != 3) continue;
        var sectionName = split[0].Replace("#", "");
        var endpoint = r.Replace(split[1], string.Empty);
        var section = stateSummary.Sections.FirstOrDefault(s => s.Name == sectionName);
        if (section == null)
        {
            section = new Section(sectionName);
            stateSummary.Sections.Add(section);
        }
        section.Endpoints.Add(endpoint);
    }
    stateSummaries.Add(stateSummary);
}

var json = JsonSerializer.Serialize(stateSummaries);
const string path = "state-summaries.json";
await File.WriteAllTextAsync(path, FormatJsonText(json));

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"A summary of all METRC states has been written to: {path}

Please copy this file to the root of the solution.");
Console.WriteLine($@"Summary: 
States Found: {stateSummaries.Count}");
Console.ResetColor();

#region Methods

static async Task<string?> ApiContentAsync(string state)
{

    var client = new HttpClient();
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
}

static string FormatJsonText(string jsonString)
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
    return new System.Text.UTF8Encoding()
        .GetString(memoryStream.ToArray());
}

#endregion Methods

#region Models

internal class Section
{
    public Section(string name)
    {
        Name = name;
        Endpoints = new List<string>();
    }
    public string Name { get; set; }
    public ICollection<string> Endpoints { get; set; }
}

internal class StateSummary
{
    public StateSummary(string state)
    {
        State = state;
        Sections = new List<Section>();
    }
    public string State { get; set; }
    public ICollection<Section> Sections { get; set; }
}

#endregion Models