using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace OpenMetrc;

public partial class MetrcService : IMetrcService
{
    //protected static ConcurrentDictionary<string, IMetrcClient> MetrcClients = new();
    internal static ConcurrentDictionary<string, IEmployeeClient> EmployeeClients = new();
    internal static ConcurrentDictionary<string, IFacilityClient> FacilityClients = new();
    internal static ConcurrentDictionary<string, IHarvestClient> HarvestClients = new();
    internal static ConcurrentDictionary<string, IItemClient> ItemClients = new();
    internal static ConcurrentDictionary<string, ILabTestClient> LabTestClients = new();
    internal static ConcurrentDictionary<string, ILocationClient> LocationClients = new();
    internal static ConcurrentDictionary<string, IPackageClient> PackageClients = new();
    internal static ConcurrentDictionary<string, IPatientClient> PatientClients = new();
    internal static ConcurrentDictionary<string, IPlantClient> PlantClients = new();
    internal static ConcurrentDictionary<string, IPlantBatchClient> PlantBatchClients = new();
    internal static ConcurrentDictionary<string, ISaleClient> SaleClients = new();
    internal static ConcurrentDictionary<string, IStrainClient> StrainClients = new();
    internal static ConcurrentDictionary<string, ITransferClient> TransferClients = new();
    internal static ConcurrentDictionary<string, IUnitOfMeasureClient> UnitOfMeasureClients = new();

    public MetrcService(string state = "xx", string softwareApiKey = "xx", string userApiKey = "xx",
        bool isSandbox = false, bool returnEmptyOnNotSupported = true)
    {
        ReturnEmptyOnNotSupported = returnEmptyOnNotSupported;
        State = state;
        SoftwareApiKey = softwareApiKey;
        UserApiKey = userApiKey;
        IsSandbox = isSandbox;

        //if (MetrcClients.Any(c => c.Key == MetrcClientKey)) return;
        if (FacilityClients.Any(c => c.Key == MetrcClientKey)) return;

        var baseUrl = $@"https://{(IsSandbox ? "sandbox-" : "")}api-{state}.metrc.com";
        var client = new HttpClient(new RateLimitHttpMessageHandler { InnerHandler = new HttpClientHandler() });
        var byteArray = Encoding.ASCII.GetBytes($"{softwareApiKey}:{userApiKey}");
        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        //MetrcClients.TryAdd(MetrcClientKey, new MetrcClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        EmployeeClients.TryAdd(MetrcClientKey,
            new EmployeeClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        FacilityClients.TryAdd(MetrcClientKey,
            new FacilityClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        HarvestClients.TryAdd(MetrcClientKey,
            new HarvestClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        ItemClients.TryAdd(MetrcClientKey, new ItemClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        LabTestClients.TryAdd(MetrcClientKey,
            new LabTestClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        LocationClients.TryAdd(MetrcClientKey,
            new LocationClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        PackageClients.TryAdd(MetrcClientKey,
            new PackageClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        PatientClients.TryAdd(MetrcClientKey,
            new PatientClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        PlantClients.TryAdd(MetrcClientKey,
            new PlantClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        PlantBatchClients.TryAdd(MetrcClientKey,
            new PlantBatchClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        SaleClients.TryAdd(MetrcClientKey, new SaleClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        StrainClients.TryAdd(MetrcClientKey,
            new StrainClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        TransferClients.TryAdd(MetrcClientKey,
            new TransferClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
        UnitOfMeasureClients.TryAdd(MetrcClientKey,
            new UnitOfMeasureClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
    }

    protected string MetrcClientKey => $@"{SoftwareApiKey}:{UserApiKey}";

    //protected IMetrcClient UserMetrcClient => MetrcClients[MetrcClientKey];
    protected IEmployeeClient EmployeeClient => EmployeeClients[MetrcClientKey];
    protected IFacilityClient FacilityClient => FacilityClients[MetrcClientKey];
    protected IHarvestClient HarvestClient => HarvestClients[MetrcClientKey];
    protected IItemClient ItemClient => ItemClients[MetrcClientKey];
    protected ILabTestClient LabTestClient => LabTestClients[MetrcClientKey];
    protected ILocationClient LocationClient => LocationClients[MetrcClientKey];
    protected IPackageClient PackageClient => PackageClients[MetrcClientKey];
    protected IPatientClient PatientClient => PatientClients[MetrcClientKey];
    protected IPlantClient PlantClient => PlantClients[MetrcClientKey];
    protected IPlantBatchClient PlantBatchClient => PlantBatchClients[MetrcClientKey];
    protected ISaleClient SaleClient => SaleClients[MetrcClientKey];
    protected IStrainClient StrainClient => StrainClients[MetrcClientKey];
    protected ITransferClient TransferClient => TransferClients[MetrcClientKey];
    protected IUnitOfMeasureClient UnitOfMeasureClient => UnitOfMeasureClients[MetrcClientKey];

    /// <summary>
    ///     METRC is not in all states and not all states have the same endpoint. If this value is true, an empty result will
    ///     be returned instead of a `ReturnEmptyOnNotSupported` exception
    /// </summary>
    public bool ReturnEmptyOnNotSupported { get; set; }

    public string State { get; set; }
    public bool IsSandbox { get; set; }
    public string SoftwareApiKey { get; set; }
    public string UserApiKey { get; set; }
    public IEnumerable<string> AvailableStates => MetrcEndpointExtensions.GetAvailableStates();
    public IEmployeeClient Employees => this;
    public IFacilityClient Facilities => this;
    public IHarvestClient Harvests => this;
    public IItemClient Items => this;
    public ILabTestClient LabTests => this;
    public ILocationClient Locations => this;
    public IPackageClient Packages => this;
    public IPatientClient Patients => this;
    public IPlantClient Plants => this;
    public IPlantBatchClient PlantBatches => this;
    public ISaleClient Sales => this;
    public IStrainClient Strains => this;
    public ITransferClient Transfers => this;
    public IUnitOfMeasureClient UnitOfMeasures => this;

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