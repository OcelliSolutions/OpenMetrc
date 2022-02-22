using System.Collections.Generic;

namespace OpenMetrc.Tests.Models;

public class ApiKey
{
    private OpenMetrcConfig _openMetrcConfig = null!;
    internal MetrcService MetrcService = new(new OpenMetrcConfig("", "", ""));

    public ApiKey(OpenMetrcConfig openMetrcConfig)
    {
        openMetrcConfig.ReturnEmptyOnNotSupported = true;
        openMetrcConfig.FacilityLimitCount = 25;
        openMetrcConfig.IntegratorLimitCount = 75;
        OpenMetrcConfig = openMetrcConfig;
    }

    public OpenMetrcConfig OpenMetrcConfig {
        get => _openMetrcConfig;
        set {
            _openMetrcConfig = value;
            MetrcService = new MetrcService(value);
        }
    }

    public ICollection<Facility> Facilities { get; set; } = new HashSet<Facility>();
    public ICollection<Transfer?> Transfers { get; set; } = new HashSet<Transfer?>();
    public ICollection<TransferDelivery> TransferDeliveries { get; set; } = new HashSet<TransferDelivery>();

    public ICollection<Transfer?> TransferTemplates { get; set; } = new HashSet<Transfer?>();

    //public ICollection<TransferDelivery> TransferDeliveryTemplates { get; set; } = new HashSet<TransferDelivery>();
    public bool IsReadOnly =>
        !OpenMetrcConfig.IsSandbox; //only the sandbox will be written to when doing integration testing
}