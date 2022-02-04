using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace OpenMetrc;

public partial class MetrcService : IMetrcService
{
    protected static ConcurrentDictionary<string, IMetrcClient> MetrcClients = new();

    public MetrcService(string state = "xx", string softwareApiKey = "xx", string userApiKey = "xx",
        bool isSandbox = false, bool returnEmptyOnNotSupported = true)
    {
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        State = state;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        IsSandbox = isSandbox;

        if (MetrcClients.Any(c => c.Key == MetrcClientKey)) return;

        var baseUrl = $@"https://{(IsSandbox ? "sandbox-" : "")}api-{state}.metrc.com";
        var client = new HttpClient(new RateLimitHttpMessageHandler { InnerHandler = new HttpClientHandler() });
        var byteArray = Encoding.ASCII.GetBytes($"{softwareApiKey}:{userApiKey}");
        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        MetrcClients.TryAdd(MetrcClientKey,
            new MetrcClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
    }

    protected string MetrcClientKey => $@"{SoftwareApiKey}:{UserApiKey}";
    protected IMetrcClient UserMetrcClient => MetrcClients[MetrcClientKey];

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