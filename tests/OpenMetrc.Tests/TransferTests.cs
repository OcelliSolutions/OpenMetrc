using System;

namespace OpenMetrc.Tests;

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
    [Order(1)]
    public async void GetIncomingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var transfers =
                        await apiKey.MetrcService.Transfers.GetIncomingTransfersAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null);
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.Transfers.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (transfers.Any()) break;
                    daysBack--;
                    if (daysBack < -30) break;
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [Order(1)]
    public async void GetOutgoingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var transfers =
                        await apiKey.MetrcService.Transfers.GetOutgoingTransfersAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null);
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.Transfers.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (transfers.Any()) break;
                    daysBack--;
                    if (daysBack < -30) break;
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [Order(1)]
    public async void GetRejectedTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var transfers = await apiKey.MetrcService.Transfers.GetRejectedTransfersAsync(facility.License.Number);
                wasTested = wasTested || transfers.Any();
                foreach (var transfer in transfers)
                {
                    apiKey.Transfers.Add(transfer);
                    _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                }
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [Fact(Skip = "Transfer Templates are very slow to test and have yet to every return results")]
    public async void GetTransferTemplatesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var transfers =
                        await apiKey.MetrcService.Transfers.GetTransferTemplatesAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null);
                    wasTested = wasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.TransferTemplates.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }

                    if (transfers.Any()) break;
                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [Order(2)]
    public async void GetTransferDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transfer in apiKey.Transfers)
            try
            {
                var deliveries =
                    await apiKey.MetrcService.Transfers.GetTransferDeliveriesAsync(transfer.Id);
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                {
                    apiKey.TransferDeliveries.Add(delivery);
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {transfer.Id}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    [SkippableFact]
    [Order(3)]
    public async void GetTransferDeliveryPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var transferDelivery in apiKey.TransferDeliveries)
            try
            {
                var deliveries =
                    await apiKey.MetrcService.Transfers.GetTransferDeliveryPackagesAsync(transferDelivery.Id);
                wasTested = wasTested || deliveries.Any();
                foreach (var delivery in deliveries)
                    _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: {transferDelivery.Id}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Transfers for any license");
    }

    #region Simple Tests

    [SkippableFact]
    public async void GetActiveStrainsAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var transfers = await apiKey.MetrcService.Transfers.GetTransferDeliveryPackageStatesAsync();
                wasTested = wasTested || transfers.Any();
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.SubDomain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Strains for any license");
    }

    #endregion Simple Tests
}