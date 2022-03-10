using System;
using System.Text.Json;

namespace OpenMetrc.Tests;

public class SaleReceiptTests : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ITestOutputHelper _testOutputHelper;

    public SaleReceiptTests(ITestOutputHelper testOutputHelper, SharedFixture sharedFixture)
    {
        _testOutputHelper = testOutputHelper;
        Fixture = sharedFixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
    }

    private SharedFixture Fixture { get; }

    [SkippableFact]
    public async void GetActiveSaleReceiptsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var saleReceipts =
                        await apiKey.MetrcService.Sales.GetActiveSaleReceiptsAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null);
                    if (saleReceipts == null) continue;
                    wasTested = wasTested || saleReceipts.Any();
                    foreach (var saleReceipt in saleReceipts)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(saleReceipt, facility.License.Number);
                        if (saleReceipt.Transactions == null || !saleReceipt.Transactions.Any()) continue;

                        //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                        _testOutputHelper.WriteLine(JsonSerializer.Serialize(saleReceipt.Transactions));
                        Assert.Empty(saleReceipt.Transactions);
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
        Skip.IfNot(wasTested, "WARN: There were no testable SaleReceipts for any license");
    }

    [SkippableFact]
    public async void GetInactiveSaleReceiptsAsync_AdditionalPropertiesAreEmpty_ShouldPass()
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
                    var saleReceipts =
                        await apiKey.MetrcService.Sales.GetInactiveSaleReceiptsAsync(facility.License.Number,
                            DateTimeOffset.UtcNow.AddDays(daysBack), null, null, null);
                    if (saleReceipts == null) continue;
                    wasTested = wasTested || saleReceipts.Any();
                    foreach (var saleReceipt in saleReceipts)
                    {
                        _additionalPropertiesHelper.CheckAdditionalProperties(saleReceipt, facility.License.Number);
                        if (saleReceipt.Transactions == null || !saleReceipt.Transactions.Any()) continue;

                        //Tests are only returning an empty array. Once a result comes in that has content, fail this test and figure out what it should be.
                        _testOutputHelper.WriteLine(JsonSerializer.Serialize(saleReceipt.Transactions));
                        Assert.Empty(saleReceipt.Transactions);
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
        Skip.IfNot(wasTested, "WARN: There were no testable SaleReceipts for any license");
    }

    [SkippableFact]
    public async void GetSaleCustomerTypesAsync_ValidEndpoint_ShouldPass()
    {
        var wasTested = false;
        var unauthorized = 0;
        var timeout = 0;
        foreach (var apiKey in Fixture.ApiKeys)
            try
            {
                var saleReceipts = await apiKey.MetrcService.Sales.GetSaleCustomerTypesAsync();
                wasTested = wasTested || saleReceipts.Any();
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
                _testOutputHelper.WriteLine($@"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
                timeout++;
            }

        Skip.If(!wasTested && unauthorized > 0, "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(!wasTested && timeout > 0, "WARN: All responses timed out. Could not test.");
        Skip.IfNot(wasTested, "WARN: There were no testable SaleReceipts for any license");
    }
}