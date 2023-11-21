using OpenMetrc.Tests.V1.Attributes;
using OpenMetrc.Tests.V1.Fixtures;
using OpenMetrc.Tests.V1.Helpers;
using System;

namespace OpenMetrc.Tests.V1.Services;

[TestCaseOrderer("OpenMetrc.Tests.Orderers.PriorityOrderer", "OpenMetrc.Tests")]
public class TransferTests
    (ITestOutputHelper testOutputHelper, SharedFixture sharedFixture) : IClassFixture<SharedFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper = new(testOutputHelper);

    [SkippableFact]
    [TestPriority(1)]
    public void GetIncomingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var transfers = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetIncomingTransfersAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (transfers == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
                        foreach (var transfer in transfers)
                        {
                            apiKey.IncomingTransfers.Add(transfer);
                            _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                        }

                        if (apiKey.IncomingTransfers.Count >= 5) break;
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
    [TestPriority(1)]
    public void GetOutgoingTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var transfers = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetOutgoingTransfersAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (transfers == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
                        foreach (var transfer in transfers)
                        {
                            apiKey.OutgoingTransfers.Add(transfer);
                            _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                        }

                        if (apiKey.OutgoingTransfers.Count >= 10) break;
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
    [TestPriority(1)]
    public void GetRejectedTransfersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var transfers = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Transfers.GetRejectedTransfersAsync(facility.License.Number).Result);
                    if (transfers == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
                    foreach (var transfer in transfers)
                    {
                        apiKey.RejectedTransfers.Add(transfer);
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                    }
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [Fact(Skip = "Transfer Templates are very slow to test and have yet to every return results")]
    public void GetTransferTemplatesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        var daysBack = -1;
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                do
                    try
                    {
                        var transfers = sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferTemplatesAsync(facility.License.Number,
                                DateTimeOffset.UtcNow.AddDays(daysBack), null).Result);
                        if (transfers == null) continue;
                        testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
                        foreach (var transfer in transfers)
                        {
                            apiKey.TransferTemplates.Add(transfer);
                            _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                        }

                        if (transfers.Any()) break;
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
    [TestPriority(2)]
    public void GetTransferDeliveriesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var transfer in apiKey.Transfers)
                try
                {
                    if (transfer == null) continue;
                    var deliveries =
                        sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferDeliveriesAsync(transfer.Id).Result);
                    if (deliveries == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || deliveries.Any();
                    foreach (var delivery in deliveries)
                    {
                        apiKey.TransferDeliveries.Add(delivery);
                        _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                    }
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryPackagesAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var transferDelivery in apiKey.TransferDeliveries)
                try
                {
                    var deliveries =
                        sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferDeliveryPackagesAsync(transferDelivery.Id).Result);
                    if (deliveries == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || deliveries.Any();
                    foreach (var delivery in deliveries)
                        _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryPackagesWholesaleAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var transferDelivery in apiKey.TransferDeliveries)
                try
                {
                    var deliveries =
                        sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferDeliveryPackagesWholesaleAsync(transferDelivery.Id)
                                .Result);
                    if (deliveries == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || deliveries.Any();
                    foreach (var delivery in deliveries)
                        _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryTransportersAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var transferDelivery in apiKey.TransferDeliveries)
                try
                {
                    var deliveries =
                        sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferDeliveryTransportersAsync(transferDelivery.Id).Result);
                    if (deliveries == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || deliveries.Any();
                    foreach (var delivery in deliveries)
                        _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    [TestPriority(3)]
    public void GetTransferDeliveryTransportersDetailAsync_AdditionalPropertiesAreEmpty_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var transferDelivery in apiKey.TransferDeliveries)
                try
                {
                    var deliveries =
                        sharedFixture.SafeExecutor(() =>
                            apiKey.MetrcService.Transfers.GetTransferDeliveryTransportersDetailAsync(transferDelivery.Id)
                                .Result);
                    if (deliveries == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || deliveries.Any();
                    foreach (var delivery in deliveries)
                        _additionalPropertiesHelper.CheckAdditionalProperties(delivery, string.Empty);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    #region Simple Tests

    [SkippableFact]
    public void GetTransferDeliveryPackageStatesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            try
            {
                var transfers = sharedFixture.SafeExecutor(() =>
                    apiKey.MetrcService.Transfers.GetTransferDeliveryPackageStatesAsync().Result);
                testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
            }
            catch (SharedFixture.TestExceptionWrapper ex)
            {
                sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
            }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    [SkippableFact]
    public void GetTransferTypesAsync_ValidEndpoint_ShouldPass()
    {
        var testEndpointResult = new TestEndpointResult();
        foreach (var apiKey in sharedFixture.ApiKeys)
            foreach (var facility in apiKey.Facilities)
                try
                {
                    var transfers = sharedFixture.SafeExecutor(() =>
                        apiKey.MetrcService.Transfers.GetTransferTypesAsync(facility.License.Number).Result);
                    if (transfers == null) continue;
                    testEndpointResult.WasTested = testEndpointResult.WasTested || transfers.Any();
                    foreach (var transfer in transfers)
                        _additionalPropertiesHelper.CheckAdditionalProperties(transfer, facility.License.Number);
                }
                catch (SharedFixture.TestExceptionWrapper ex)
                {
                    sharedFixture.HandleTestEndpointException(ex, testEndpointResult, apiKey, testOutputHelper);
                }

        sharedFixture.AlertIfSkippableTest(testEndpointResult);
    }

    #endregion Simple Tests
}