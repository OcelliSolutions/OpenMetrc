using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;
using System;

namespace OpenMetrc.V1.Tests.Services;

public class SaleTransactionTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetSaleTransactionsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var saleTransactions = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Sales.GetSaleTransactionsAsync(facility.License.Number).Result);
                    if (saleTransactions == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || saleTransactions.Any();
                    foreach (var saleTransaction in saleTransactions)
                        _additionalPropertiesHelper.CheckAdditionalProperties(saleTransaction, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetSaleTransactionByDateRangeAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var saleTransactions = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales
                            .GetSaleTransactionByDateRangeAsync(
                                DateTime.UtcNow.AddDays(daysBack - 1),
                                DateTime.UtcNow.AddDays(daysBack),
                                facility.License.Number).Result);
                        if (saleTransactions == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || saleTransactions.Any();
                        foreach (var saleTransaction in saleTransactions)
                            _additionalPropertiesHelper.CheckAdditionalProperties(saleTransaction, facility.License.Number);
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