using System;

namespace OpenMetrc.Tests;

public class PackageTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public PackageTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public void GetActivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetActivePackagesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);

                    if (packages == null) continue;
                    wasTested = wasTested || packages.Any();
                    foreach (var package in packages)
                        _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public void GetInactivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetInactivePackagesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (packages == null) continue;
                    wasTested = wasTested || packages.Any();
                    foreach (var package in packages)
                        _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public void GetOnHoldPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetOnHoldPackagesAsync(facility.License.Number,
                        DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                    if (packages == null) continue;
                    wasTested = wasTested || packages.Any();
                    foreach (var package in packages)
                        _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }


    [SkippableFact]
    public void GetPackageAdjustReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetPackageAdjustReasonsAsync(facility.License.Number).Result);
                if (packages == null) continue;
                wasTested = wasTested || packages.Any();
                foreach (var package in packages)
                    _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
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
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public void GetPackageTypesAsync_ValidEndpoint_ShouldPass()
    {
        //this endpoint just returns a list of strings, there are no additional properties to look for
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetPackageTypesAsync().Result);
                //var packages = Fixture.SafeExecutor(() => apiKey.MetrcService.Packages.GetPackageTypesAsync().Result);
                wasTested = wasTested || packages.Any();
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
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }
}