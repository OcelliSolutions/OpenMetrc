using OpenMetrc.Tests.Models;
using OpenMetrc.V1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace OpenMetrc.Tests.Fixtures;

public class SharedFixture : IDisposable
{
    public SharedFixture()
    {
        try
        {
            var apiKeysJson = File.ReadAllText("api_keys.json");
            Debug.Assert(!string.IsNullOrWhiteSpace(apiKeysJson), "Please create a `api_keys.json` file");

            var settings = JsonSerializer.Deserialize<ApiKeySetting>(apiKeysJson) ?? new ApiKeySetting();
            Debug.Assert(settings.OpenMetrcConfigs != null, "settings.OpenMetrcConfigs != null");

            ApiKeys = settings.OpenMetrcConfigs.Select(c => new ApiKey(c) { DaysToTest = settings.DaysToTest })
                .ToList();
            Debug.Assert(ApiKeys != null, "Please specify some api keys in `api_keys.json` before testing");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex);
        }
        catch (Exception ex)
        {
            throw new KeyNotFoundException($@"Please create a `api_keys.json` file. {ex.Message}");
        }

        this.LoadFacilities().Wait();
        //Task.Run(async () => await this.LoadFacilities()).Wait();
    }

    public List<ApiKey> ApiKeys { get; set; } = new();

    public void Dispose()
    {
        ApiKeys.Clear();
        GC.SuppressFinalize(this);
    }

    public async Task LoadFacilities()
    {
        foreach (var key in ApiKeys)
            try
            {
                var facilities = await key.MetrcService.Facilities.GetFacilitiesAsync();

                if (facilities == null) continue;
                var sampleFacilities = facilities.Where(f => f.IsOwner ?? false).Take(3).ToList();
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanGrowPlants ?? false).Take(3));
                sampleFacilities.AddRange(facilities.Where(f => f.FacilityType.CanSellToPatients ?? false).Take(3));
                key.Facilities = sampleFacilities;
            }
            catch (ApiException<ErrorResponse?> ex)
            {
                Console.WriteLine($@"SubDomain: {key.OpenMetrcConfig.SubDomain} - {ex.Message}");
            }
            catch (ApiException ex)
            {
                Console.WriteLine($@"SubDomain: {key.OpenMetrcConfig.SubDomain} - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"SubDomain: {key.OpenMetrcConfig.SubDomain} - {ex.Message}");
            }
    }

    public T SafeExecutor<T>(Func<T> action)
    {
        try
        {
            return action();
        }
        catch (ApiException<ErrorResponse?> ex)
        {
            if (ex.StatusCode is StatusCodes.Status401Unauthorized or StatusCodes.Status503ServiceUnavailable)
                throw new TestExceptionWrapper(null, null, ex.InnerException, true);
            throw new TestExceptionWrapper(ex.Result?.Message ?? ex.Message, ex.Response, ex.InnerException);
        } /*
        catch (ApiException ex)
        {
            if (ex.StatusCode == StatusCodes.Status503ServiceUnavailable)
                throw new TestExceptionWrapper(null, null, ex.InnerException, unavailable: true);
            throw new TestExceptionWrapper(ex.Message, ex.Response, ex.InnerException);
        }*/
        catch (TimeoutException ex)
        {
            throw new TestExceptionWrapper(ex.Message, null, null, unavailable: true);
        }
        catch (AggregateException ex)
        {
            ex.Handle(ie => {
                if (ie is ApiException<ErrorResponse> apiException)
                {
                    if (apiException.StatusCode is StatusCodes.Status401Unauthorized
                        or StatusCodes.Status503ServiceUnavailable)
                        throw new TestExceptionWrapper(null, null, ex.InnerException, true);
                    throw new TestExceptionWrapper(apiException.Result?.Message ?? apiException.Message,
                        apiException.Response,
                        ex.InnerException);
                }

                if (ie is TimeoutException timeoutException)
                    throw new TestExceptionWrapper(timeoutException.Message, null, null, unavailable: true);

                throw ie;
            });
            throw;
        }
        catch (Exception ex)
        {
            throw new TestExceptionWrapper(ex.Message, ex.InnerException);
        }
    }

    public TestEndpointResult HandleTestEndpointException(TestExceptionWrapper ex,
        TestEndpointResult testEndpointResult, ApiKey apiKey, ITestOutputHelper testOutputHelper)
    {
        if (ex.Unauthorized || ex.Unavailable)
        {
            testEndpointResult.Unauthorized++;
            return testEndpointResult;
        }

        if (ex.Timeout)
        {
            testOutputHelper.WriteLine($"{apiKey.OpenMetrcConfig.SubDomain}: Timeout");
            testEndpointResult.Timeout++;
        }
        else
        {
            testOutputHelper.WriteLine(ex.Message);
            if (!string.IsNullOrWhiteSpace(ex.Response))
                testOutputHelper.WriteLine(ex.Response);
        }

        return testEndpointResult;
    }

    public void AlertIfSkippableTest(TestEndpointResult testEndpointResult)
    {
        Skip.If(testEndpointResult is { WasTested: false, Unauthorized: > 0 },
            "WARN: All responses came back as 401 Unauthorized. Could not test.");
        Skip.If(testEndpointResult is { WasTested: false, Timeout: > 0 },
            "WARN: All responses timed out. Could not test.");
        Skip.IfNot(testEndpointResult.WasTested, "WARN: There were no testable Transfers for any license");
    }

    public class TestExceptionWrapper : Exception
    {
        public TestExceptionWrapper(string? message, string? response, Exception? innerException,
            bool unauthorized = false, bool unavailable = false, bool timeout = false,
            bool couldNotDeserialize = false) : base(message, innerException)
        {
            Response = response;
            Unauthorized = unauthorized;
            Unavailable = unavailable;
            CouldNotDeserialize = couldNotDeserialize;
            Timeout = timeout;
        }

        public TestExceptionWrapper(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public string? Response { get; }
        public bool Unauthorized { get; }
        public bool Unavailable { get; }
        public bool CouldNotDeserialize { get; }
        public bool Timeout { get; }
    }
}

public class TestEndpointResult
{
    public bool WasTested { get; set; }
    public int Unauthorized { get; set; }
    public int Timeout { get; set; }
}