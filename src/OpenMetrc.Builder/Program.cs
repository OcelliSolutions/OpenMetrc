using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
    {
        //ensure all endpoints report that they only work with JSON
        options.Filters.Clear();
        options.Filters.Add(new ProducesAttribute(MediaTypeNames.Application.Json));
        options.Filters.Add(new ConsumesAttribute(MediaTypeNames.Application.Json));
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        //MapClientErrors is a .NET6 feature that automatically wraps error responses if a structure is not specified. METRC does not do this so it needs to be disabled.
        options.SuppressMapClientErrors = true;
    });
builder.Services.TryAddEnumerable(ServiceDescriptor
    .Transient<IApplicationModelProvider, ProduceResponseTypeModelProvider>());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "METRC API",
            Version = "v1",
            Description =
                "This document is created and maintained by the community and is designed to be a non-state specific specification. Please refer to your regions documentation for specific details and deviations. https://api-<state/province code>.metrc.com/documentation." +
                "Please keep in mind that there are rate limits and other terms of use enforced by Franwell (METRC). This document is only designed to give developers a standard used for code generation and testing."
        }
    );

    //get all the available states that were detected by the scraper and add them as possible servers.
    var availableStates = DistinctStates().ToList();
    foreach (var state in availableStates)
        c.AddServer(new OpenApiServer { Url = $@"https://api-{state}.metrc.com" });
    foreach (var state in availableStates)
        c.AddServer(new OpenApiServer { Url = $@"https://sandbox-api-{state}.metrc.com" });

    c.EnableAnnotations();

    #region Enable OneOf and response nullability

    c.UseOneOfForPolymorphism();
    c.SelectSubTypesUsing(baseType =>
    {
        if (baseType.Name.EndsWith("Request"))
            return Enumerable.Empty<Type>();
        return new[]
        {
            baseType
        };
    });
    c.SchemaFilter<NullableResponseSchemaFilter>();

    #endregion Enable OneOf and response nullability

    c.DocumentFilter<AdditionalPropertiesDocumentFilter>();
    c.SchemaFilter<DateTimeSchemaFilter>();
    c.ParameterFilter<DateTimeParameterFilter>();
    c.OperationFilter<AuthorizationOperationFilter>();

    //Set the OperationIds for the OpenAPI spec to be the action name. Ensure that no names are duplicated across all controllers just to be safe.
    c.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["action"]}");

    //METRC uses basic authentication
    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        In = ParameterLocation.Header,
        Description =
            "Username = software_api_key = Software vendor's API key</br>Password = user_api_key = User's API key"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "basic"
                }
            },
            Array.Empty<string>()
        }
    });
});
var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "METRC API v1"));
}

app.UseAuthorization();
app.MapControllers();

app.Run();

static IEnumerable<string?> DistinctStates()
{
    const string fileName = "../../state-summaries.json";
    var jsonString = File.ReadAllText(fileName);
    var stateSummaries = JsonSerializer.Deserialize<List<StateSummary>>(jsonString)!;

    return (from ss in stateSummaries
        select ss.State).Distinct().OrderBy(e => e);
}