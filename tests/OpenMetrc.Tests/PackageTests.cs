using System;

namespace OpenMetrc.Tests;

public class PackageTests : IAssemblyFixture<SharedFixture>
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
    public async void GetActivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var packages = await apiKey.MetrcService.Packages.GetActivePackagesAsync(facility.License.Number,
                    DateTimeOffset.UtcNow.AddDays(-1), null);
                wasTested = wasTested || packages.Any();
                foreach (var package in packages)
                    _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public async void GetInactivePackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var packages = await apiKey.MetrcService.Packages.GetInactivePackagesAsync(facility.License.Number,
                    DateTimeOffset.UtcNow.AddDays(-1), null);
                wasTested = wasTested || packages.Any();
                foreach (var package in packages)
                    _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public async void GetOnHoldPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var packages = await apiKey.MetrcService.Packages.GetOnHoldPackagesAsync(facility.License.Number,
                    DateTimeOffset.UtcNow.AddDays(-1), null);
                wasTested = wasTested || packages.Any();
                foreach (var package in packages)
                    _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }


    [SkippableFact]
    public async void GetPackageAdjustReasonsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
        foreach (var facility in apiKey.Facilities)
            try
            {
                var packages = await apiKey.MetrcService.Packages.GetPackageAdjustReasonsAsync(facility.License.Number);
                wasTested = wasTested || packages.Any();
                foreach (var package in packages)
                    _additionalPropertiesHelper.CheckAdditionalProperties(package, facility.License.Number);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: {facility.License.Number}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }

    [SkippableFact]
    public async void GetPackageTypesAsync_ValidEndpoint_ShouldPass()
    {
        //this endpoint just returns a list of strings, there are no additional properties to look for
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var packages = await apiKey.MetrcService.Packages.GetPackageTypesAsync();
                wasTested = wasTested || packages.Any();
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode != StatusCodes.Status401Unauthorized) throw;
                unauthorized++;
            }
            catch (TimeoutException)
            {
                _testOutputHelper.WriteLine($@"{apiKey.Domain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable Packages for any license");
    }
}