using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using System;
using System.Text.Json;

namespace OpenMetrc.Tests.V1.Services;

public class SaleReceiptTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActiveSaleReceiptsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var saleReceipts =
                            sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetActiveSaleReceiptsAsync(
                                facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
                        if (saleReceipts == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || saleReceipts.Any();
                        foreach (var saleReceipt in saleReceipts)
                        {
                            _additionalPropertiesHelper.CheckAdditionalProperties(saleReceipt, facility.License.Number);
                            if (saleReceipt.Transactions == null || !saleReceipt.Transactions.Any()) continue;

                            //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                            testOutputHelper.WriteLine(JsonSerializer.Serialize(saleReceipt.Transactions));
                            Assert.Empty(saleReceipt.Transactions);
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
    public void GetInactiveSaleReceiptsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var saleReceipts =
                            sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetInactiveSaleReceiptsAsync(
                                facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null).Result);
                        if (saleReceipts == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || saleReceipts.Any();
                        foreach (var saleReceipt in saleReceipts)
                        {
                            _additionalPropertiesHelper.CheckAdditionalProperties(saleReceipt, facility.License.Number);
                            if (saleReceipt.Transactions == null || !saleReceipt.Transactions.Any()) continue;

                            //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                            testOutputHelper.WriteLine(JsonSerializer.Serialize(saleReceipt.Transactions));
                            Assert.Empty(saleReceipt.Transactions);
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