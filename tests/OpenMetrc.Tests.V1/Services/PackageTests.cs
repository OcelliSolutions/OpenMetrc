using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using System;

namespace OpenMetrc.Tests.V1.Services;

public class PackageTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    public void GetActivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var packages = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetActivePackagesAsync(
                            facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                        if (packages == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || packages.Any();
                        foreach (var package in packages)
                            _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
    public void GetInactivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var packages = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Packages
                            .GetInactivePackagesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (packages == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || packages.Any();
                        foreach (var package in packages)
                            _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
    public void GetOnHoldPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var packages = sharedFixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetOnHoldPackagesAsync(
                            facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (packages == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || packages.Any();
                        foreach (var package in packages)
                            _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
    public void GetPackageAdjustReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var packages = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Packages.GetPackageAdjustReasonsAsync(facility.License.Number).Result);
                    if (packages == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || packages.Any();
                    foreach (var package in packages)
                        _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetPackageTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var packages =
                    sharedFixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetPackageTypesAsync().Result);
                //var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetPackageTypesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || packages.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }
}