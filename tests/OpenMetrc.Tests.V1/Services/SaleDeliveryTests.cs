using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using System;
using System.Text.Json;

namespace OpenMetrc.Tests.V1.Services;

public class SaleDeliveryTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var saleDeliveries =
                            sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetActiveSaleDeliveriesAsync(
                                facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
                        if (saleDeliveries == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || saleDeliveries.Any();
                        foreach (var saleDelivery in saleDeliveries)
                        {
                            _additionalPropertiesHelper.CheckAdditionalProperties(saleDelivery, facility.License.Number);
                            if (saleDelivery.Transactions == null || !saleDelivery.Transactions.Any()) continue;

                            //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                            testOutputHelper.WriteLine(JsonSerializer.Serialize(saleDelivery.Transactions));
                            Assert.Empty(saleDelivery.Transactions);
                        }

                        daysBack--;
                        if (daysBack < -apiKey.DaysToTest) break;
                    }
                    catch (SharedFixture.TestExceptionWrapper ex)
                    {
                        sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                        break;
                    }
                while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetInactiveSaleDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var saleDeliveries =
                            sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetInactiveSaleDeliveriesAsync(
                                facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
                        if (saleDeliveries == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || saleDeliveries.Any();
                        foreach (var saleDelivery in saleDeliveries)
                        {
                            _additionalPropertiesHelper.CheckAdditionalProperties(saleDelivery, facility.License.Number);
                            if (saleDelivery.Transactions == null || !saleDelivery.Transactions.Any()) continue;

                            //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                            testOutputHelper.WriteLine(JsonSerializer.Serialize(saleDelivery.Transactions));
                            Assert.Empty(saleDelivery.Transactions);
                        }

                        daysBack--;
                        if (daysBack < -apiKey.DaysToTest) break;
                    }
                    catch (SharedFixture.TestExceptionWrapper ex)
                    {
                        sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                        break;
                    }
                while (true);

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}