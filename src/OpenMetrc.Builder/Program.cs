using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
    {
        options.Filters.Clear();
        options.Filters.Add(new ProducesAttribute(MediaTypeNames.Application.Json));
        options.Filters.Add(new ConsumesAttribute(MediaTypeNames.Application.Json));
    })
    .ConfigureApiBehaviorOptions(options =>
    {
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
    /*
    c.AddServer(new OpenApiServer { Url = "https://api-ak.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-al.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ar.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-az.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ca.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-co.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ct.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-cz.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-dc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-de.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-fl.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ga.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-gu.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-hi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ia.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-id.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-il.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-in.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ks.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ky.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-la.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ma.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-md.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-me.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-mi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-mn.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-mo.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ms.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-mt.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nd.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ne.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nh.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nj.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nm.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-nv.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ny.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-oh.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ok.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-or.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-pa.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-pr.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ri.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-sc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-sd.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-tn.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-tx.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-ut.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-va.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-vi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-vt.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-wa.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-wi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-wv.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://api-wy.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ak.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-al.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ar.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-az.metrc.com" });
    */
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ca.metrc.com" });
    /*
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-co.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ct.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-cz.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-dc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-de.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-fl.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ga.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-gu.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-hi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ia.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-id.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-il.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-in.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ks.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ky.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-la.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ma.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-md.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-me.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-mi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-mn.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-mo.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ms.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-mt.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nd.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ne.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nh.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nj.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nm.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-nv.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ny.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-oh.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ok.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-or.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-pa.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-pr.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ri.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-sc.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-sd.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-tn.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-tx.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-ut.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-va.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-vi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-vt.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-wa.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-wi.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-wv.metrc.com" });
    c.AddServer(new OpenApiServer { Url = "https://sandbox-api-wy.metrc.com" });
    */
    c.EnableAnnotations();
    c.DocumentFilter<AdditionalPropertiesDocumentFilter>();
    c.SchemaFilter<DateTimeSchemaFilter>();
    c.ParameterFilter<DateTimeParameterFilter>();
    c.OperationFilter<AuthorizationOperationFilter>();

    c.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["action"]}");

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