namespace OpenMetrc.Builder.Models.Requests;

public class AddAdditiveToPlantByLocationRequest
{
    public AddAdditiveToPlantByLocationRequest()
    {
        AdditiveType = string.Empty;
        ProductTradeName = string.Empty;
        ProductSupplier = string.Empty;
        ApplicationDevice = string.Empty;
        TotalAmountUnitOfMeasure = string.Empty;
        ActiveIngredients = new List<ActiveIngredient>();
        LocationName = string.Empty;
    }
    public string AdditiveType { get; set; }
    public string ProductTradeName { get; set; }
    public string? EpaRegistrationNumber { get; set; }
    public string ProductSupplier { get; set; }
    public string ApplicationDevice { get; set; }
    public double TotalAmountApplied { get; set; }
    public string TotalAmountUnitOfMeasure { get; set; }
    public List<ActiveIngredient> ActiveIngredients { get; set; }
    public string LocationName { get; set; }
    public DateTime ActualDate { get; set; }
}
