using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using OpenMetrc.V1;
using System.Collections.Generic;

namespace OpenMetrc.Tests.V1.Services;

public class SaleTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetSaleCustomerTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result =
                    sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetSaleCustomerTypesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPatientRegistrationLocationsAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Sales.GetPatientRegistrationLocationsAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested ||
                                               (result ?? new List<PatientRegistrationLocation>()).Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetDeliveryReturnReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Sales.GetDeliveryReturnReasonsAsync().Result);
                if (result == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
                foreach (var item in result)
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetCountiesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetCountiesAsync().Result);
                if (result == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
                foreach (var item in result)
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPaymentTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var result = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Sales.GetPaymentTypesAsync(facility.License.Number).Result);
                    if (result == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetTransactionsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var result = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Sales.GetTransactionsAsync(facility.License.Number).Result);
                    if (result == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
                    foreach (var item in result)
                        _additionalPropertiesHelper.CheckAdditionalProperties(item, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}