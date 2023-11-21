namespace OpenMetrc.Scraper.Models;

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