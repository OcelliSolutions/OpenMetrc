using System;
using System.Text.Json;

namespace OpenMetrc.Tests.V1;

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
    public void GetActiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                            Fixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetActiveSaleDeliveriesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
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
        Skip.IfNot(wasTested, "WARN: There were no testable SaleDeliveries for any license");
    }

    [SkippableFact]
    public void GetInactiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                            Fixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetInactiveSaleDeliveriesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
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
        Skip.IfNot(wasTested, "WARN: There were no testable SaleDeliveries for any license");
    }
}