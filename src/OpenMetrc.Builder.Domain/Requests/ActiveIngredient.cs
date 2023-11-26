namespace OpenMetrc.Builder.Domain.Requests;

public class ActiveIngredient
{
    public ActiveIngredient()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }
    public double Percentage { get; set; }
}