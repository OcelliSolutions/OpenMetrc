namespace OpenMetrc.Builder.Models;

internal class StateSummary
{
    public StateSummary(string state, Section[] sections)
    {
        State = state;
        Sections = sections;
    }

    public string State { get; set; }
    public Section[] Sections { get; set; }
}

internal class Section
{
    public Section(string name, string[] endpoints)
    {
        Name = name;
        Endpoints = endpoints;
    }

    public string Name { get; set; }
    public string[] Endpoints { get; set; }
}