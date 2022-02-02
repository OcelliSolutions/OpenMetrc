using System.Diagnostics;

namespace OpenMetrc;

public partial class MetrcService
{
    protected IMetrcClient MetrcClient;

    public MetrcService(IMetrcClient metrcClient, string state, string softwareApiKey, string userApiKey,
        bool isSandbox,
        bool returnEmptyOnNotSupported = false)
    {
        MetrcClient = metrcClient;
        MetrcClient.ConfigureClient(softwareApiKey, userApiKey);
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        State = state;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        IsSandbox = isSandbox;
    }

    /// <summary>
    ///     METRC is not in all states and not all states have the same endpoint. If this value is true, an empty result will
    ///     be returned instead of a `ReturnEmptyOnNotSupported` exception
    /// </summary>
    public bool ReturnEmptyOnNotSupported { get; set; }

    public string State { get; set; }
    public bool IsSandbox { get; set; }
    public string SoftwareApiKey { get; set; }
    public string UserApiKey { get; set; }
    public IEmployee Employees => this;
    public IFacility Facilities => this;
    public IHarvest Harvests => this;
    public IItem Items => this;
    public ILabTest LabTests => this;
    public ILocation Locations => this;
    public IPackage Packages => this;
    public IPatient Patients => this;
    public IPlant Plants => this;
    public IPlantBatch PlantBatches => this;
    public ISaleReceipt SaleReceipts => this;
    public ISaleTransaction SaleTransactions => this;
    public IStrain Strains => this;
    public ITransfer Transfers => this;
    public IUnitOfMeasure UnitOfMeasures => this;

    protected bool CheckEndpointAvailability(MethodBase? method)
    {
        Debug.Assert(method != null, nameof(method) + " != null");
        var endpoint =
            method.GetCustomAttributes(typeof(MapsToApiAttribute), true).FirstOrDefault() as MapsToApiAttribute;
        Debug.Assert(endpoint != null, nameof(endpoint) + " != null");
        var states = endpoint.States;
        if (states.Contains(State)) return true;
        if (!ReturnEmptyOnNotSupported) throw new NotSupportedException("This state does not support this endpoint");
        return false;
    }
}