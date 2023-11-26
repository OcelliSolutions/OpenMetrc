using OpenMetrc.V1.Tests.Fixtures;
using OpenMetrc.V1.Tests.Helpers;
using System.Collections.Generic;

namespace OpenMetrc.V1.Tests.Services;

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
    public void GetSalePatientRegistrationLocationsAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Sales.GetSalePatientRegistrationLocationsAsync().Result);
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
    public void GetSaleDeliveryReturnReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
        {

            try
            {
                var result = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Sales.GetSaleDeliveryReturnReasonsAsync(facility.License.Number).Result);
                if (result == null) continue;
                testEndpointResult.WasTested = testEndpointResult.WasTested || result.Any();
                foreach (var item in result)
                    _additionalPropertiesHelper.CheckAdditionalProperties(item, string.Empty);
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }
        }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetSaleCountiesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var result = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Sales.GetSaleCountiesAsync().Result);
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
    public void GetSalePaymentTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var result = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Sales.GetSalePaymentTypesAsync(facility.License.Number).Result);
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
    public void GetSaleTransactionsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var result = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Sales.GetSaleTransactionsAsync(facility.License.Number).Result);
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