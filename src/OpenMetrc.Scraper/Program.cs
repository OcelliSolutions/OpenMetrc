using System.Collections.Concurrent;
using OpenMetrc.Scraper;
using OpenMetrc.Scraper.Models;

//all possible states and province codes that METRC could be operating in.
var states = new List<string>
{
    "al", "ak", "az", "ar", "ca", "cz", "co", "ct", "de", "dc", "fl", "ga", "gu", "hi", "id", "il", "in", "ia",
    "ks", "ky", "la", "me", "md", "ma", "mi", "mn", "ms", "mo", "mt", "ne", "nv", "nh", "nj", "nm", "ny", "nc", "nd",
    "oh", "ok", "or", "pa", "pr", "ri", "sc", "sd", "tn", "tx", "ut", "vt", "vi", "va", "wa", "wv", "wi", "wy"
};
var stateSummaries = new ConcurrentBag<StateSummary>();
double stateCounter = 0;
var consoleLock = new object();
var errors = new ConcurrentBag<Exception>();

StateService.DeleteReferenceDocuments();

Parallel.ForEach(states, state =>
{
    try
    {
        var stateSummary = StateService.ProcessState(state).Result;

        // Thread-safe increment of the counter and console update
        lock (consoleLock)
        {
            stateCounter++;
            Console.Write("\rScanning: {0} {1:P}   ", state, stateCounter / states.Count);
        }

        stateSummaries.Add(stateSummary);
    }
    catch (Exception ex)
    {
        errors.Add(ex);
    }
});

if (!errors.IsEmpty)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    foreach (var exception in errors) Console.WriteLine(exception.Message);
    Console.ResetColor();
    Console.WriteLine();
}

await StateService.WriteStateSummary(stateSummaries.ToList());


var v1Document = OpenApiService.CreateOpenApiDocument("../../../Reference", "v1");
await OpenApiService.WriteOpenApiDocument(v1Document);
var v2Document = OpenApiService.CreateOpenApiDocument("../../../Reference", "v2");
await OpenApiService.WriteOpenApiDocument(v2Document);


await OpenApiService.CreateController(v1Document, "V1");
await OpenApiService.CreateController(v2Document, "V2");

Console.WriteLine($@"Summary: 
States Found: {stateSummaries.Count}");
Console.ResetColor();