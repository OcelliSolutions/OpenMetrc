using OpenMetrc.Scraper;
using OpenMetrc.Scraper.Models;

//all possible states and province codes that METRC could be operating in.
var states = new List<string>
{
    "al", "ak", "az", "ar", "ca", "cz", "co", "ct", "de", "dc", "fl", "ga", "gu", "hi", "id", "il", "in", "ia",
    "ks", "ky", "la", "me", "md", "ma", "mi", "mn", "ms", "mo", "mt", "ne", "nv", "nh", "nj", "nm", "ny", "nc", "nd",
    "oh", "ok", "or", "pa", "pr", "ri", "sc", "sd", "tn", "tx", "ut", "vt", "vi", "va", "wa", "wv", "wi", "wy"
};
var stateSummaries = new List<StateSummary>();
var stateCounter = 0.0;
foreach (var state in states)
{
    stateCounter++;
    Console.Write("\rScanning: {0} {1:P}   ", state, stateCounter / states.Count);

    var stateSummary = await StateService.ProcessState(state);

    // don't add a state that is only a placeholder or only has unit of measure.
    if (stateSummary.Sections.Count <= 1)
        continue;
    stateSummaries.Add(stateSummary);
}

await StateService.WriteStateSummary(stateSummaries);
Console.WriteLine($@"Summary: 
States Found: {stateSummaries.Count}");
Console.ResetColor();
