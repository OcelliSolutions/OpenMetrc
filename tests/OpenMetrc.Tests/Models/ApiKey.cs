using System.Collections.Generic;

namespace OpenMetrc.Tests.Models;

public class ApiKey
{
    private OpenMetrcConfig _openMetrcConfig = null!;
    //internal MetrcService MetrcService = new(new OpenMetrcConfig("", "", ""));
    internal MetrcService MetrcService = new(){OpenMetrcConfig = new OpenMetrcConfig("", "", "")};

    public ApiKey(OpenMetrcConfig openMetrcConfig)
    {
        openMetrcConfig.ReturnEmptyOnNotSupported = true;
        openMetrcConfig.CallsPerSecondPerFacility = 40;
        openMetrcConfig.CallsPerSecondPerIntegrator = 130;
        openMetrcConfig.ConcurrentCallsPerSecondPerFacility = 3;
        openMetrcConfig.ConcurrentCallsPerSecondPerIntegrator = 3;

        OpenMetrcConfig = openMetrcConfig;
    }

    public OpenMetrcConfig OpenMetrcConfig {
        get => _openMetrcConfig;
        set {
            _openMetrcConfig = value;
            //MetrcService = new MetrcService(value);
            MetrcService = new MetrcService{OpenMetrcConfig = value};
        }
    }

    public ICollection<Facility> Facilities { get; set; } = new HashSet<Facility>();
    public ICollection<Transfer?> IncomingTransfers { get; set; } = new HashSet<Transfer?>();
    public ICollection<Transfer?> OutgoingTransfers { get; set; } = new HashSet<Transfer?>();
    public ICollection<Transfer?> RejectedTransfers { get; set; } = new HashSet<Transfer?>();
    public ICollection<Transfer?> Transfers => IncomingTransfers.Union(OutgoingTransfers).Union(RejectedTransfers).ToList();
    public ICollection<TransferDelivery> TransferDeliveries { get; set; } = new HashSet<TransferDelivery>();

    public ICollection<Transfer?> TransferTemplates { get; set; } = new HashSet<Transfer?>();

    //public ICollection<TransferDelivery> TransferDeliveryTemplates { get; set; } = new HashSet<TransferDelivery>();
    public bool IsReadOnly =>
        !OpenMetrcConfig.IsSandbox; //only the sandbox will be written to when doing integration testing
}