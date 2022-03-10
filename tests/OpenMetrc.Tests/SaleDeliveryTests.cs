using System;
using System.Text.Json;

namespace OpenMetrc.Tests;

public class SaleDeliveryTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public SaleDeliveryTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public async void GetActiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var saleDeliveries =
                        await apiKey.MetrcService.Sales.GetActiveSaleDeliveriesAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null);
                    if (saleDeliveries == null) continue;
                    wasTested = wasTested || saleDeliveries.Any();
                    foreach (var saleDelivery in saleDeliveries)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(saleDelivery, facility.License.Number);
                        if (saleDelivery.Transactions == null || !saleDelivery.Transactions.Any()) continue;

                        //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                        _testOutputHelper.WriteLine(JsonSerializer.Serialize(saleDelivery.Transactions));
                        Assert.Empty(saleDelivery.Transactions);
                    }

                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException<ErrorResponse?> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                        ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                    {
                        if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                        _testOutputHelper.WriteLine(ex.Response);
                        throw;
                    }

                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine(
                        $@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable SaleDeliveries for any license");
    }

    [SkippableFact]
    public async void GetInactiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var saleDeliveries =
                        await apiKey.MetrcService.Sales.GetInactiveSaleDeliveriesAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null);
                    if (saleDeliveries == null) continue;
                    wasTested = wasTested || saleDeliveries.Any();
                    foreach (var saleDelivery in saleDeliveries)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(saleDelivery, facility.License.Number);
                        if (saleDelivery.Transactions == null || !saleDelivery.Transactions.Any()) continue;

                        //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                        _testOutputHelper.WriteLine(JsonSerializer.Serialize(saleDelivery.Transactions));
                        Assert.Empty(saleDelivery.Transactions);
                    }

                    daysBack--;
                    if (daysBack < -10) break;
                }
                catch (ApiException<ErrorResponse?> ex)
                {
                    if (ex.StatusCode != StatusCodes.Status401Unauthorized &&
                        ex.StatusCode != StatusCodes.Status503ServiceUnavailable)
                    {
                        if (ex.Result != null) _testOutputHelper.WriteLine(ex.Result.Message);
                        _testOutputHelper.WriteLine(ex.Response);
                        throw;
                    }

                    unauthorized++;
                }
                catch (TimeoutException)
                {
                    _testOutputHelper.WriteLine(
                        $@"{apiKey.OpenMetrcConfig.SubDomain}: {facility.License.Number}: Timeout");
                    timeout++;
                }
            while (true);

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable SaleDeliveries for any license");
    }
}