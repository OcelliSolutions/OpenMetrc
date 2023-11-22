using HtmlAgilityPack;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Models;
using NSwag.CodeGeneration.OperationNameGenerators;
using OpenMetrc.Scraper.Models;
using PluralizeService.Core;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OpenMetrc.Scraper;
internal class OpenApiService
{
    internal static OpenApiDocument CreateOpenApiDocument(string baseDirectory, string version)
    {
        var document = new OpenApiDocument
        {
            Info = new OpenApiInfo { Title = "METRC API", Version = version },
            Components = { Schemas  = {  }}
        };

        var filePattern =$"*_{version}*.html";
        var filePaths = Directory.GetFiles(baseDirectory, filePattern, SearchOption.AllDirectories);

        foreach (var filePath in filePaths)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.Load(filePath);
            var directory = new DirectoryInfo(filePath);
            var section = directory.Parent?.Parent?.Name;

            var endpointInfo = ExtractEndpointInfo(htmlDoc, section);
            if (endpointInfo == null) continue;

            if (!document.Paths.ContainsKey(endpointInfo.Url))
            {
                document.Paths.Add(endpointInfo.Url, new OpenApiPathItem());
            }

            var operation = new OpenApiOperation
            {
                //Summary = endpointInfo.Summary,
                //Description = endpointInfo.Description,
                OperationId = endpointInfo.OperationId,
                
            };
            foreach (var parameter in endpointInfo.Parameters)
            {
                operation.Parameters.Add(parameter.OpenApiParameter);
            }
            
            operation.Responses.Add("200", new OpenApiResponse() { Description = "Ok"});

            if (endpointInfo.ExampleRequest != null)
            {
                var schemaName = $"{operation.OperationId}Request";
                var schema = new JsonSchema();
                //document.Schemes.Add(new OpenApiResponse(){ });
                document.Components.Schemas.TryAdd(schemaName, schema);
                //operation.RequestBody = new OpenApiRequestBody() { IsRequired = true, Name = $"{endpointInfo.OperationId}Request", Content = { {"application/json", new OpenApiMediaType(){}  }}};
            }
            //operation.ExternalDocumentation = new OpenApiExternalDocumentation() { Url = filePath };

            operation.Tags.Add(section);
            document.Paths[endpointInfo.Url].TryAdd(endpointInfo.HttpMethod, operation);
        }

        return document;
    }

    internal static async Task WriteOpenApiDocument(OpenApiDocument document)
    {
        var path = $"../../../OpenApi/metrc-swagger-{document.Info.Version}.yaml";
        var yamlContent = document.ToYaml();
        await File.WriteAllTextAsync(path, yamlContent);
    }

    private static EndpointInfo ExtractEndpointInfo(HtmlDocument htmlDoc, string section)
    {
        var endpointInfo = new EndpointInfo();

        // Extract the HTTP method and URL
        var endpointHeader = htmlDoc.DocumentNode.SelectSingleNode("//h3[contains(@id, 'get_') or contains(@id, 'post_') or contains(@id, 'put_') or contains(@id, 'delete_')]");
        if (endpointHeader != null)
        {
            // Extract the operation ID from the id attribute of the h3 tag
            var operationId = endpointHeader.GetAttributeValue("id", string.Empty);
            endpointInfo.OperationId = CleanOperationId(operationId, section);

            var parts = endpointHeader.InnerText.Split(new[] { ' ' }, 2);
            if (parts.Length == 2)
            {
                endpointInfo.HttpMethod = parts[0].Trim();
                endpointInfo.Url = parts[1].Trim();
            }
        }

        // Extract route parameters from URL
        var routeParamsMatches = Regex.Matches(endpointInfo.Url, @"\{([^\}]+)\}");
        foreach (Match match in routeParamsMatches)
        {
            var paramName = match.Groups[1].Value;
            var paramType = paramName.Equals("id", StringComparison.OrdinalIgnoreCase) ? JsonObjectType.Integer : JsonObjectType.String;

            var routeParam = new ParameterInfo
            {
                Name = paramName,
                Description = $"Route parameter {paramName}",
                IsOptional = false,
                Type = paramType,
                Kind = OpenApiParameterKind.Path
            };

            endpointInfo.Parameters.Add(routeParam);
        }

        // Extract Parameters
        var parameterTables = htmlDoc.DocumentNode.SelectNodes("//h4[contains(text(), 'Parameters')]/following-sibling::table[1]/tbody/tr");
        if (parameterTables != null)
        {
            foreach (var row in parameterTables)
            {
                var paramName = row.SelectSingleNode("td[1]").InnerText.Trim();
                paramName = paramName.Replace("optional", "");
                if(paramName == "No parameters")
                    continue;
                var parameterInfo = new ParameterInfo
                {
                    Name = paramName,
                    Description = row.SelectSingleNode("td[2]").InnerText.Trim(),
                    IsOptional = row.InnerHtml.Contains("optional", StringComparison.OrdinalIgnoreCase),
                    Type = JsonObjectType.String,
                    Kind = OpenApiParameterKind.Query
                };
                
                endpointInfo.Parameters.Add(parameterInfo);
            }
        }

        // Extract Example Request
        if (!endpointInfo.OperationId.StartsWith("Get"))
        {
            var exampleRequest = htmlDoc.DocumentNode.SelectSingleNode("//h4[contains(text(), 'Example Request')]/following-sibling::pre/code");
            if (exampleRequest != null)
            {
                endpointInfo.ExampleRequest = exampleRequest.InnerText.Trim();
            }
        }

        // Extract Example Response
        var exampleResponse = htmlDoc.DocumentNode.SelectSingleNode("//h4[contains(text(), 'Example Response')]/following-sibling::pre/code");
        if (exampleResponse != null)
        {
            endpointInfo.ExampleResponse = exampleResponse.InnerText.Trim();
        }

        return endpointInfo;
    }

    public static string CleanOperationId(string operationId, string section)
    {
        // Replace placeholders with descriptive text or remove them
        //operationId = operationId.Replace("{", "").Replace("}", "");
        operationId = Regex.Replace(operationId, @"\{.*?\}", "");

        // Remove versions like "V1", "V2", etc.
        operationId = Regex.Replace(operationId, @"_v\d+", "", RegexOptions.IgnoreCase);

        operationId = operationId.TrimEnd('_');
        //if (!operationId.ToLower().EndsWith(section.ToLower()))
        //    operationId = operationId.Replace($"_{section}", string.Empty, StringComparison.InvariantCultureIgnoreCase);

        // Singularize each word
        var words = operationId.Split('_');
        for (var i = 0; i < words.Length - 1; i++)
        {
            if (string.IsNullOrWhiteSpace(words[i]))
                continue;

            words[i] = PluralizationProvider.Singularize(words[i]);
        }

        operationId = string.Join("_", words);

        // Convert to Proper Case
        operationId = ConvertToProperCase(operationId);

        // Further clean up as needed
        // ...

        return operationId;
    }

    private static readonly char[] Separator = new[] { '_', '-', ' ' };

    private static string ConvertToProperCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        var textInfo = CultureInfo.InvariantCulture.TextInfo;
        var words = str.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
        return string.Join("", words.Select(w => textInfo.ToTitleCase(w.ToLower())));
    }

    public static async Task CreateController(OpenApiDocument document, string version)
    {
        const string controllerName = "MetrcBase";
        const string controllerNamespace = "OpenMetrc.Builder.Controllers";
        const string modelNamespace = "OpenMetrc.Builder.Controllers.V1";
        try
        {
            var settings = new CSharpControllerGeneratorSettings()
            {
                //ClassName = controllerName,
                OperationNameGenerator = new MultipleClientsFromFirstTagAndOperationIdGenerator(),
                GenerateClientInterfaces = true,
                GenerateOptionalParameters = true,
                AdditionalNamespaceUsages = new[] { "System.Text.Json" },
                ControllerTarget = CSharpControllerTarget.AspNetCore,
                ControllerStyle = CSharpControllerStyle.Abstract,
                CodeGeneratorSettings =
                {
                    SchemaType = SchemaType.OpenApi3
                },
                CSharpGeneratorSettings =
                {
                    Namespace = modelNamespace,
                    JsonLibrary = CSharpJsonLibrary.SystemTextJson,
                    //GenerateOptionalPropertiesAsNullable = true,
                    GenerateNullableReferenceTypes = true,
                    GenerateDefaultValues = true,
                    GenerateDataAnnotations = true,
                    GenerateNativeRecords = true, DateType = "DateTime",
                    PropertyNameGenerator = new CustomPropertyNameGenerator()
                }
            };

            var generator = new CSharpControllerGenerator(document, settings);
            var code = generator.GenerateFile();

            //Declare a new input parameter for POST and PUT methods.
            var keyWords = new List<string>()
            {
                "Post", "Put"
            };
            foreach (var keyWord in keyWords)
            {
                code = Regex.Replace(code, $@"Task ({keyWord}\w+)\(", $@"Task $1([System.ComponentModel.DataAnnotations.Required] {modelNamespace}.$1Request request, ");
            }

            code = code.Replace("HttpDELETE", "HttpDelete")
                .Replace("HttpGET", "HttpGet")
                .Replace("HttpPUT", "HttpPut")
                .Replace("HttpPOST", "HttpPost");

            code = code.Replace(", )", ")")
                .Replace("<br/>", "")
                .Replace("<br />", "");
            var path = @"../../../../OpenMetrc.Builder/Controllers";
            //var path = $@"../../../../OpenMetrc.Builder/Delete";
            path = Path.Combine(path, version);
            DirectoryService.CreateFoldersIfMissing(path);
            path = Path.Combine(path, $@"{controllerName}Controller.cs");
            await File.WriteAllTextAsync(path, code);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"{ex.Message} | {controllerName}");
            Console.ResetColor();
        }
    }

    private static async Task CreateExtendedControllerIfMissing(string section, string controllerName)
    {
        var template = $@"using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OpenMetrc.Builder.Models;
using OpenMetrc.Common.Attributes;
using OpenMetrc.Common.Data;

namespace OpenMetrc.Builder.Controllers.{section};

/// <inheritdoc />
[ApiGroup(ApiGroupNames.{section})]
[ApiController]
public class {controllerName}Controller : {controllerName}ControllerOrig {{}}";

        var path = @"../../../../OpenMetrc.Builder/Controllers";
        if (controllerName == "AccessScope")
            path = @"../../../../OpenMetrc.OAuth.Builder/Controllers";
        if (!string.IsNullOrWhiteSpace(section))
            path = Path.Combine(path, section);
        DirectoryService.CreateFoldersIfMissing(path);
        path = Path.Combine(path, $@"{controllerName}Controller.Extended.cs");
        if (!File.Exists(path))
            await File.WriteAllTextAsync(path, template);
    }
}
