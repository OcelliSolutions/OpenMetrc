namespace OpenMetrc.Builder.Domain;

public class Section
{
    public Section(string name, string[] endpoints)
    {
        Name = name;
        Endpoints = endpoints;
    }

    public string Name { get; set; }
    public string[] Endpoints { get; set; }
}