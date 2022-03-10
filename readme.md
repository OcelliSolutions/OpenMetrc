# OpenMETRC

OpenMETRC is two part project. The first is an OpenAPI specification for the METRC api. This spec can be used with any programming language to generate client code to work with the API with all the correct parameters and models. The second is a .NET library that adds a wrapper for the generated client code that enables several features such as:

* Credential Management
* Rate Limiting
* State/Endpoint Validation

The [METRC State &amp; Endpoint Coverage](src\OpenMetrc\Data\MetrcEndpointsSummary.md) report will show the coverage of this application. _Currently, only GET endpoints are tested although POST, PUT, and DELETE are implemented as well._

## Installation

OpenMETRC is [available on NuGet](https://github.com/codecooper/OpenMetrc/). Use the package manager console in Visual Studio to install it:

```powershell
Install-Package OpenMETRC
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```sh
dotnet add package openmetrc
```

## Quick Start

For the purpose of rate limiting, you should register OpenMetrc as a singleton.

```c#
var openMetrcConfig = new OpenMetrcConfig("api-co", "xx", "xx");
var metrcService = new MetrcService(openMetrcConfig);`
try
{
    var facilities = await metrcService.Facilities.GetFacilitiesAsync();
}
catch (ApiException<ErrorResponse?> ex)
{
    //The ex.Result will return the error message, if any, from METRC.
    Console.WriteLine(ex.Result?.Message);
    Console.WriteLine(ex.Message);
}
```

### Using Dependency Injection

You may also use dependency injection by adding:

```csharp
//use either of these but not both.
services.AddSingleton<OpenMetrc.IMetrcService, OpenMetrc.MetrcService>();
//services.AddSingleton<OpenMetrc.IMetrcService>(m => new MetrcService(new OpenMetrcConfig("xx","xx","xx",true)));
```

Either way, you can override the `OpenMetrcConfig` at any time.

## Frequently Asked Questions

* **Question**: Is it secure?
  * **Answer**: This is  just a wrapper for the METRC apis. All communication is directly between you and METRC over HTTPS. 

* **Question**: How do I use OpenMETRC with a my state's implementation of METRC?
  * **Answer**: OpenMETRC works with any METRC implementation, no extra configuration needed. All you need to do is pass in your `sub_domain`, `software_api_key` (Vendor Key), and `user_api_key`. There are two optional constructor properties that you can use to manage your connection.
    * ReturnEmptyOnNotSupported: not every state has every endpoint. If `false`, a `NotSupportedException` is returned. If `true`, an empty result is returned. Default `true`.
    * FacilityLimitCount: override the default of 50 calls per second per facility. You may need to play with this because your applications start instant of 1 second may not line up with METRC's.
    * IntegratorLimitCount: override the default of 150 calls per second per integrator key. You may need to play with this because your applications start instant of 1 second may not line up with METRC's.

```c#
var openMetrcConfig = new OpenMetrcConfig("api-co", "xx", "xx");
var metrcService = new MetrcService(openMetrcConfig);`
```

> :bulb: The subdomain is different for every state/province where METRC is deployed. Some examples are:
> * https://<mark>api-co</mark>.metrc.com
> * https://<mark>sandbox-api-co</mark>.metrc.com
> * https://<mark>api-nv</mark>.metrc.com
> * https://<mark>sandbox-api-nv</mark>.metrc.com


* **Question**: How does the rate limiting work?
  * **Answer**: OpenMETRC uses a combination of static/global ConcurrentDictionaries and Semaphores to limit executions to the following rules. There are still some instances where a `429 Too Many Requests` can be returned. It is still a good practice to handle this exception.
    * 50 GET calls per second per facility,
    * 150 GET calls per second per ~~integrator key~~ state sub-domain
    * 10 concurrent GET calls per second per facility
    * 30 concurrent GET calls per second per ~~integrator key~~ state sub-domain
  * **TODO**: Change the state url rate limits to integration key limits to better align with the official rate limits.

## [OpenAPI/Swagger](https://swagger.io/specification/)

This project is based around the idea that every REST API should have good documentation based on the OpenAPI spec. METRC does not publish such a spec, so we made one. And just to be sure that the spec is good and works against all (as we can test) endpoints, OpenMetrc is based solely on it.

## Development/Contribution

There are several applications in this repo that aid in creating the final project. This development flow is designed around the idea of **eating your own dog food**. As a developer, the OpenAPI specification can be a god-sent when integrating with third-party APIs. When built correctly, you should be able to use off the shelf code generators to create the client code in your native programming language. Too many times, this spec is either incomplete or just does not exist.

The first step is to create an OpenAPI spec for a library that you do not own. Second, you need to be able to generate all the client code and be able to run integration testing to ensure you have all the variables, formatting, and result structures fully mapped. With OpenMETRC, this is accomplished with a few applications.

### [OpenMETRC: Scraper](src/OpenMetrc.Scraper/readme.md)

Given a list of all possible states that METRC may be deployed do, scrape the documentation sites and compile a list (`state-summaries.json`) of all the states and the endpoints that they expose.

### [OpenMETRC: Builder](src/OpenMetrc.Builder/readme.md)

This project is an OpenAPI spec builder for the METRC platform. This uses several helpers to ensure that all endpoints scraped and are mapped to controllers and endpoints with the appropriate return types and error structures. The final result of this tool is `open-metrc-swagger.yaml`. This file can use used by any platform for code generation.

### [OpenMETRC](src/OpenMetrc/readme.md)

The core NuGet package and final product.

### [OpenMETRC Tests](tests/OpenMetrc.Tests/readme.md)

Used to test the OpenMETRC  library. This allows for a developer to test all endpoint for any and all states and companies they may have access too. This also allows testing against sandbox environments.
