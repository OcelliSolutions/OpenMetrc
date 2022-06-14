using OpenMetrc.Tests.Attributes;
using System;

namespace OpenMetrc.Tests;


[TestCaseOrderer("OpenMetrc.Tests.Orderers.PriorityOrderer", "OpenMetrc.Tests")]
public class TransferTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public TransferTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    [TestPriority(1)]
    public void GetIncomingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var transfers = Fixture.SafeExecutor(() =>
                        apiKey.MetrcService.Transfers.GetIncomingTransfersAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (transfers == null) continue;
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.IncomingTransfers.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (apiKey.IncomingTransfers.Count >= 5) break;
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(1)]
    public void GetOutgoingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var transfers = Fixture.SafeExecutor(() =>
                        apiKey.MetrcService.Transfers.GetOutgoingTransfersAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (transfers == null) continue;
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.OutgoingTransfers.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (apiKey.OutgoingTransfers.Count >= 10) break;
                        daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(1)]
    public void GetRejectedTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var transfers = Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetRejectedTransfersAsync(facility.License.Number).Result);
                if (transfers == null) continue;
                wasTested = wasTested || transfers.Any();
                foreach (var transfer in transfers)
                {
                    apiKey.RejectedTransfers.Add(transfer);
                    _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                }
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [Fact(Skip = "Transfer Templates are very slow to test and have yet to every return results")]
    public void GetTransferTemplatesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        var daysBack = -1;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            do
                try
                {
                    var transfers = Fixture.SafeExecutor(() =>
                        apiKey.MetrcService.Transfers.GetTransferTemplatesAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (transfers == null) continue;
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.TransferTemplates.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (transfers.Any()) break;
                    daysBack--;
                    if (daysBack < -apiKey.DaysToTest) break;
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    if (ex.Unauthorized || ex.Unavailable)
                    {
                        unauthorized++;
                        break;
                    }
                    if (ex.Timeout)
                    {
                        _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                        timeout++;
                    }
                    else
                    {
                        _testOutputHelper.WriteLine(ex.Message);
                        if (!string.IsNullOrWhiteSpace(ex.Response))
                            _testOutputHelper.WriteLine(ex.Response);
                        break;
                    }
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(2)]
    public void GetTransferDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transfer in apiKey.Transfers)
            try
            {
                if (transfer == null) continue;
                var deliveries =
                    Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveriesAsync(transfer.Id).Result);
                if (deliveries == null) continue;
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                {
                    apiKey.TransferDeliveries.Add(delivery);
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transferDelivery in apiKey.TransferDeliveries)
            try
            {
                var deliveries =
                    Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveryPackagesAsync(transferDelivery.Id).Result);
                if (deliveries == null) continue;
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryPackagesWholesaleAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transferDelivery in apiKey.TransferDeliveries)
            try
            {
                var deliveries =
                    Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveryPackagesWholesaleAsync(transferDelivery.Id).Result);
                if (deliveries == null) continue;
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryTransportersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transferDelivery in apiKey.TransferDeliveries)
            try
            {
                var deliveries =
                    Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveryTransportersAsync(transferDelivery.Id).Result);
                if (deliveries == null) continue;
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryTransportersDetailAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transferDelivery in apiKey.TransferDeliveries)
            try
            {
                var deliveries =
                    Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveryTransportersDetailAsync(transferDelivery.Id).Result);
                if (deliveries == null) continue;
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    #region Simple Tests

    [SkippableFact]
    public void GetTransferDeliveryPackageStatesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var transfers = Fixture.SafeExecutor(() => apiKey.MetrcService.Transfers.GetTransferDeliveryPackageStatesAsync().Result);
                wasTested = wasTested || transfers.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                if (ex.Unauthorized || ex.Unavailable)
                {
                    unauthorized++;
                    continue;
                }
                if (ex.Timeout)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                    timeout++;
                }
                else
                {
                    _testOutputHelper.WriteLine(ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.Response))
                        _testOutputHelper.WriteLine(ex.Response);
                }
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Strains for any license");
    }

    #endregion Simple Tests
}