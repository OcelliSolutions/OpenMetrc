namespace OpenMetrc.Builder.Domain;

public class StateSummary
{
    public StateSummary(string state, Section[] sections)
    {
        State = state;
        Sections = sections;
    }

    public string State { get; set; }
    public Section[] Sections { get; set; }
}