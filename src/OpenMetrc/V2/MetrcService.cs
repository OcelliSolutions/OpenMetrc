using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace OpenMetrc.V2;

public partial class MetrcService : IMetrcService
{
    //protected static ConcurrentDictionary<string, IMetrcClient> MetrcClients = new();
    internal static ConcurrentDictionary<string, ICaregiverClient> CaregiverClients = new();
    internal static ConcurrentDictionary<string, IEmployeeClient> EmployeeClients = new();
    internal static ConcurrentDictionary<string, IFacilityClient> FacilityClients = new();
    internal static ConcurrentDictionary<string, IHarvestClient> HarvestClients = new();
    internal static ConcurrentDictionary<string, IItemClient> ItemClients = new();
    internal static ConcurrentDictionary<string, ILabTestClient> LabTestClients = new();
    internal static ConcurrentDictionary<string, ILocationClient> LocationClients = new();
    internal static ConcurrentDictionary<string, IPackageClient> PackageClients = new();
    internal static ConcurrentDictionary<string, IPatientCheckInClient> PatientCheckInClients = new();
    internal static ConcurrentDictionary<string, IPatientClient> PatientClients = new();
    internal static ConcurrentDictionary<string, IPlantClient> PlantClients = new();
    internal static ConcurrentDictionary<string, IPlantBatchClient> PlantBatchClients = new();
    internal static ConcurrentDictionary<string, IProcessingClient> ProcessingClients = new();
    internal static ConcurrentDictionary<string, ISaleClient> SaleClients = new();
    internal static ConcurrentDictionary<string, IStrainClient> StrainClients = new();
    internal static ConcurrentDictionary<string, ITagClient> TagClients = new();
    internal static ConcurrentDictionary<string, ITransferClient> TransferClients = new();
    internal static ConcurrentDictionary<string, IUnitOfMeasureClient> UnitOfMeasureClients = new();
    internal static ConcurrentDictionary<string, IWasteMethodClient> WasteMethodClients = new();

    protected static HttpClient? HttpClient;
    OpenMetrcConfig? _openMetrcConfig;

    public MetrcService()
    {
        OpenMetrcConfig = new OpenMetrcConfig("xx", "xx", "xx");
    }

    public MetrcService(OpenMetrcConfig openMetrcConfig)
    {
        OpenMetrcConfig = openMetrcConfig;
    }
    /*
    public MetrcService(OpenMetrcConfig openMetrcConfig)
    {
        //if (MetrcClients.Any(c => c.Key == MetrcClientKey)) return;
        //if (FacilityClients.Any(c => c.Key == MetrcClientKey)) return;

        OpenMetrcConfig = openMetrcConfig;
    }*/

    protected string MetrcClientKey => $@"{OpenMetrcConfig.SoftwareApiKey}:{OpenMetrcConfig.UserApiKey}";

    //protected IMetrcClient UserMetrcClient => MetrcClients[MetrcClientKey];
    protected ICaregiverClient CaregiverClient => CaregiverClients[MetrcClientKey];
    protected IEmployeeClient EmployeeClient => EmployeeClients[MetrcClientKey];
    protected IFacilityClient FacilityClient => FacilityClients[MetrcClientKey];
    protected IHarvestClient HarvestClient => HarvestClients[MetrcClientKey];
    protected IItemClient ItemClient => ItemClients[MetrcClientKey];
    protected ILabTestClient LabTestClient => LabTestClients[MetrcClientKey];
    protected ILocationClient LocationClient => LocationClients[MetrcClientKey];
    protected IPackageClient PackageClient => PackageClients[MetrcClientKey];
    protected IPatientCheckInClient PatientCheckInClient => PatientCheckInClients[MetrcClientKey];
    protected IPatientClient PatientClient => PatientClients[MetrcClientKey];
    protected IPlantClient PlantClient => PlantClients[MetrcClientKey];
    protected IPlantBatchClient PlantBatchClient => PlantBatchClients[MetrcClientKey];
    protected IProcessingClient ProcessingClient => ProcessingClients[MetrcClientKey];
    protected ISaleClient SaleClient => SaleClients[MetrcClientKey];
    protected IStrainClient StrainClient => StrainClients[MetrcClientKey];
    protected ITagClient TagClient => TagClients[MetrcClientKey];
    protected ITransferClient TransferClient => TransferClients[MetrcClientKey];
    protected IUnitOfMeasureClient UnitOfMeasureClient => UnitOfMeasureClients[MetrcClientKey];
    protected IWasteMethodClient WasteMethodClient => WasteMethodClients[MetrcClientKey];

    public OpenMetrcConfig OpenMetrcConfig
    {
        get => _openMetrcConfig ?? new OpenMetrcConfig("api-xx", "xx", "xx");
        set
        {
            _openMetrcConfig = value;


            var baseUrl =
                $@"https://{OpenMetrcConfig.SubDomain}.metrc.com";
            HttpClient = new HttpClient(new RateLimitHttpMessageHandler
            {
                InnerHandler = new HttpClientHandler(),
                CallsPerSecondPerFacility = _openMetrcConfig.CallsPerSecondPerFacility,
                CallsPerSecondPerIntegrator = _openMetrcConfig.CallsPerSecondPerIntegrator,
                ConcurrentCallsPerSecondPerFacility = _openMetrcConfig.ConcurrentCallsPerSecondPerFacility,
                ConcurrentCallsPerSecondPerIntegrator = _openMetrcConfig.ConcurrentCallsPerSecondPerIntegrator
            });
            HttpClient.Timeout = _openMetrcConfig.HttpTimeout;
            //MetrcClients.TryAdd(MetrcClientKey, new MetrcClient(client) { BaseUrl = baseUrl, ReadResponseAsString = false });
            var byteArray = Encoding.ASCII.GetBytes($"{_openMetrcConfig.SoftwareApiKey}:{_openMetrcConfig.UserApiKey}");
            HttpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpClient.Timeout = TimeSpan.FromMinutes(3);
            CaregiverClients.TryAdd(MetrcClientKey,
                new CaregiverClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            EmployeeClients.TryAdd(MetrcClientKey,
                new EmployeeClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            FacilityClients.TryAdd(MetrcClientKey,
                new FacilityClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            HarvestClients.TryAdd(MetrcClientKey,
                new HarvestClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            ItemClients.TryAdd(MetrcClientKey,
                new ItemClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            LabTestClients.TryAdd(MetrcClientKey,
                new LabTestClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            LocationClients.TryAdd(MetrcClientKey,
                new LocationClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            PackageClients.TryAdd(MetrcClientKey,
                new PackageClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            PatientCheckInClients.TryAdd(MetrcClientKey,
                new PatientCheckInClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            PatientClients.TryAdd(MetrcClientKey,
                new PatientClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            PlantClients.TryAdd(MetrcClientKey,
                new PlantClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            PlantBatchClients.TryAdd(MetrcClientKey,
                new PlantBatchClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            ProcessingClients.TryAdd(MetrcClientKey,
                new ProcessingClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            SaleClients.TryAdd(MetrcClientKey,
                new SaleClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            StrainClients.TryAdd(MetrcClientKey,
                new StrainClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            TagClients.TryAdd(MetrcClientKey,
                new TagClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            TransferClients.TryAdd(MetrcClientKey,
                new TransferClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            UnitOfMeasureClients.TryAdd(MetrcClientKey,
                new UnitOfMeasureClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
            WasteMethodClients.TryAdd(MetrcClientKey,
                new WasteMethodClient(HttpClient) { BaseUrl = baseUrl, ReadResponseAsString = false });
        }
    }

    public IEnumerable<string> AvailableStates => MetrcEndpointExtensions.GetAvailableStates();
    public ICaregiverClient Caregivers => this;
    public IEmployeeClient Employees => this;
    public IFacilityClient Facilities => this;
    public IHarvestClient Harvests => this;
    public IItemClient Items => this;
    public ILabTestClient LabTests => this;
    public ILocationClient Locations => this;
    public IPackageClient Packages => this;
    public IPatientCheckInClient PatientCheckIns => this;
    public IPatientClient Patients => this;
    public IPlantClient Plants => this;
    public IPlantBatchClient PlantBatches => this;
    public IProcessingClient Processing => this;
    public ISaleClient Sales => this;
    public IStrainClient Strains => this;
    public ITagClient Tags => this;
    public ITransferClient Transfers => this;
    public IUnitOfMeasureClient UnitOfMeasures => this;
    public IWasteMethodClient WasteMethods => this;

    protected bool CheckEndpointAvailability(MethodBase? method)
    {
        Debug.Assert(method != null, nameof(method) + " != null");
        var endpoint =
            method.GetCustomAttributes(typeof(MapsToApiAttribute), true).FirstOrDefault() as MapsToApiAttribute;
        Debug.Assert(endpoint != null, nameof(endpoint) + " != null");
        var states = endpoint.States;
        if (states.Contains(OpenMetrcConfig.State)) return true;
        if (!OpenMetrcConfig.ReturnEmptyOnNotSupported)
            throw new NotSupportedException("This state does not support this endpoint");
        return false;
    }
}