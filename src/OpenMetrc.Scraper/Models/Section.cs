namespace OpenMetrc.Scraper.Models;

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