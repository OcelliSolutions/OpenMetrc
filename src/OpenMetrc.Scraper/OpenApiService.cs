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
    private static readonly Dictionary<string,string> OperationIds = new();
    private static readonly List<string> Int32Params = new() { "pageNumber", "pageSize" };
    private static readonly List<string> Int64Params = new() { "id", "packageId", "harvestId" };
    private static readonly List<string> BoolParams = new() { "isFromMotherPlant" };
    private static readonly List<string> DateTimeParams = new() { "lastModifiedStart", "lastModifiedEnd" };
    private static readonly List<string> DateOnlyParams = new() { "checkinDateStart", "checkinDateEnd", "salesDateStart", "salesDateEnd", "date" };

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

            var endpointInfo = ExtractEndpointInfo(htmlDoc);

            if (!document.Paths.ContainsKey(endpointInfo.Url))
            {
                document.Paths.Add(endpointInfo.Url, new OpenApiPathItem());
            }

            var operation = new OpenApiOperation
            {
                Summary = GetEndpointSummary(htmlDoc),
                Description = GetEndpointRemarks(htmlDoc),
                OperationId = endpointInfo.OperationId,
                
            };
            foreach (var parameter in endpointInfo.Parameters)
            {
                operation.Parameters.Add(parameter.OpenApiParameter);
            }
            
            operation.Responses.Add("200", new OpenApiResponse() { Description = "Ok"});
            
            // Rest of your code
            operation.ExternalDocumentation = new OpenApiExternalDocumentation
            {
                ExtensionData = new Dictionary<string, object>
                {
                    { "x-doc-key", endpointInfo.ReferenceId }
                }
            };
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

    private static EndpointInfo ExtractEndpointInfo(HtmlDocument htmlDoc)
    {
        var endpointInfo = new EndpointInfo();

        // Extract the HTTP method and URL
        var endpointHeader = htmlDoc.DocumentNode.SelectSingleNode("//h3[contains(@id, 'get_') or contains(@id, 'post_') or contains(@id, 'put_') or contains(@id, 'delete_')]");
        if (endpointHeader != null)
        {
            // Extract the operation ID from the id attribute of the h3 tag
            var operationId = endpointHeader.GetAttributeValue("id", string.Empty);
            endpointInfo.ReferenceId = operationId;
            endpointInfo.OperationId = CleanOperationId(operationId);

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
            var paramType = JsonObjectType.String;
            var paramFormat = string.Empty;
            if (Int64Params.Contains(paramName))
            {
                paramType = JsonObjectType.Integer;
                paramFormat = "int64";
            }
            if (Int32Params.Contains(paramName))
                paramType = JsonObjectType.Integer;
            if (BoolParams.Contains(paramName))
                paramType = JsonObjectType.Boolean;
            if (DateTimeParams.Contains(paramName))
                paramFormat = "date-time";
            if (DateOnlyParams.Contains(paramName))
                paramFormat = "date";

            var routeParam = new ParameterInfo
            {
                Name = paramName,
                Description = $"Route parameter {paramName}",
                IsOptional = false,
                Type = paramType,
                Format = paramFormat,
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
                var paramType = JsonObjectType.String;
                var paramFormat = string.Empty;

                paramName = paramName.Replace("optional", "");
                if(paramName == "No parameters")
                    continue;

                if (Int64Params.Contains(paramName))
                {
                    paramType = JsonObjectType.Integer;
                    paramFormat = "int64";
                }
                if (BoolParams.Contains(paramName))
                {
                    paramType = JsonObjectType.Boolean;
                }
                
                var parameterInfo = new ParameterInfo
                {
                    Name = paramName,
                    Description = row.SelectSingleNode("td[2]").InnerText.Trim(),
                    IsOptional = row.InnerHtml.Contains("optional", StringComparison.OrdinalIgnoreCase),
                    Type = paramType,
                    Format = paramFormat,
                    Kind = OpenApiParameterKind.Query
                };

                if (Int32Params.Contains(paramName))
                    parameterInfo.Type = JsonObjectType.Integer;
                if (DateOnlyParams.Contains(paramName))
                    parameterInfo.Format = "date";
                if (DateTimeParams.Contains(paramName) || row.InnerHtml.Contains("timestamp", StringComparison.OrdinalIgnoreCase))
                    parameterInfo.Format = "date-time";

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

    public static string GetEndpointSummary(HtmlDocument htmlDoc)
    {
        var summaryNode = htmlDoc.DocumentNode.SelectSingleNode("//p[@class='lead']");
        return summaryNode != null ? summaryNode.InnerText.Trim() : string.Empty;
    }

    // In this case, the remarks will be any permissions or other notes for the endpoint
    public static string GetEndpointRemarks(HtmlDocument htmlDoc)
    {
        // scrape the permissions table to get all query parameters
        var permissionsList = new List<string>();
        var permissionsTable = htmlDoc.DocumentNode.SelectNodes("//h4[contains(text(), 'Permissions Required')]/following-sibling::table[1]/tbody/tr");
        if (permissionsTable == null)
            return permissionsList.Count == 0 ? "<i>none</i>" : string.Join(" • ", permissionsList);

        foreach (var row in permissionsTable)
        {
            var permission = row.SelectSingleNode("td[1]").InnerText.Trim();
                
            var removeStrings = new List<string>(){"<strong>", "</strong>", "<em>", "</em>"};
            permission = removeStrings.Aggregate(permission, (current, removeString) => current.Replace(removeString, string.Empty));

            if (permission == "None")
                continue;
            permissionsList.Add(permission);
        }

        var printedPermissions = permissionsList.Count == 0 ? "<i>none</i>" : string.Join(" • ", permissionsList);

        // The sub-description is after the endpoint in the documentation
        var descriptionNode = htmlDoc.DocumentNode.SelectSingleNode("//h3[contains(@id, 'get_') or contains(@id, 'post_') or contains(@id, 'put_') or contains(@id, 'delete_')]/following-sibling::p");
        var description = descriptionNode.InnerText.Trim();

        description +=
            $@"{(!string.IsNullOrWhiteSpace(description) ? "</br>" : "")}<b>Permissions Required</b>: {printedPermissions}";
        return description;
    }

    public static string CleanOperationId(string operationId)
    {
        if (OperationIds.TryGetValue(operationId, out var id))
            return id;

        var originalOperationId = operationId;

        var stringReplacement = new Dictionary<string, string>()
        {
            {"_{id}", "_by_id" },
            {"_{salesDateStart}_{salesDateEnd}", "_by_date_range"},
            {"_{label}", "_by_label" },
            {"labtestdocument", "lab_test_document"},
            {"labtest", "lab_test"},
            {"labsample", "lab_sample"},
            {"removewaste", "remove_waste"},
            {"checkins", "check_ins"},
            {"moveplantbatch", "move_plant_batch"},
            {"plantbatch", "plant_batch"},
            {"changegrowthphase", "change_growth_phase"},
            {"growthphase", "growth_phase"},
            {"createpackages", "create_packages"},
            {"createplantings", "create_plantings"},
            {"frommotherplant", "from_mother_plant"},
            {"onhold", "on_hold"},
            {"bylocation", "by_location"},
            {"harvestplants", "harvest_plants"},
            {"manicureplants", "manicure_plants"},
            {"moveplants", "move_plants"},
            {"jobtype", "job_type"},
            {"customertype", "customer_type"},
            {"patientregistration", "patient_registration"},
            {"verifyID", "verify_id"},
            {"returnreason", "return_reason"},
            {"paymenttype", "payment_type"},
            {"requiredlab", "required_lab"},
            {"testbatch", "test_batch"},
            {"unitsofmeasure", "units_of_measure"},
            {"harvestedplants", "harvested_plants"},
            {"tradesample","trade_sample"},
            {"wastemethod","waste_method"}
        };

        foreach (var pair in stringReplacement)
        {
            operationId = operationId.Replace(pair.Key, pair.Value, StringComparison.InvariantCultureIgnoreCase);
        }

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

        OperationIds.TryAdd(originalOperationId, operationId);
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
        var controllerNamespace = $"OpenMetrc.{version}.Builder.Controllers";
        var modelNamespace = "OpenMetrc.Builder.Domain";
        var requestNamespace = "OpenMetrc.Builder.Domain.Requests";
        try
        {
            var settings = new CSharpControllerGeneratorSettings()
            {
                OperationNameGenerator = new MultipleClientsFromFirstTagAndOperationIdGenerator(),
                GenerateClientInterfaces = true,
                GenerateOptionalParameters = true,
                AdditionalNamespaceUsages = new[] { "System.Text.Json", "OpenMetrc.Builder.Domain", "OpenMetrc.Builder.Domain.Requests" },
                ControllerTarget = CSharpControllerTarget.AspNetCore,
                ControllerStyle = CSharpControllerStyle.Abstract,
                CodeGeneratorSettings =
                {
                    SchemaType = SchemaType.OpenApi3
                },
                CSharpGeneratorSettings =
                {
                    Namespace = controllerNamespace,
                    JsonLibrary = CSharpJsonLibrary.SystemTextJson,
                    //GenerateOptionalPropertiesAsNullable = true,
                    GenerateNullableReferenceTypes = true,
                    GenerateDefaultValues = true,
                    GenerateDataAnnotations = true,
                    GenerateNativeRecords = true,
                    DateType = "DateOnly",
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
                code = Regex.Replace(code, $@"Task ({keyWord}\w+)\(", $@"Task $1([System.ComponentModel.DataAnnotations.Required] List<{requestNamespace}.$1Request> request, ");
            }
            
            code = Regex.Replace(code, $@"Task (Delete\w+)\(\[Microsoft.AspNetCore.Mvc.FromQuery\] string licenseNumber", $@"Task $1([System.ComponentModel.DataAnnotations.Required] List<{requestNamespace}.$1Request> request, [Microsoft.AspNetCore.Mvc.FromQuery] string licenseNumber");

            // The controller code is using the wrong enum values for the Http methods.
            code = code.Replace("HttpDELETE", "HttpDelete")
                .Replace("HttpGET", "HttpGet")
                .Replace("HttpPUT", "HttpPut")
                .Replace("HttpPOST", "HttpPost");

            // Remove line breaks and leftover parentheses
            code = code.Replace(", )", ")")
                .Replace("<br/>", "")
                .Replace("<br />", "");

            var path = $"../../../../OpenMetrc.{version}.Builder/Controllers";
            //var path = $@"../../../../OpenMetrc.Builder/Delete";
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
    //TODO: figure out how to get the scraped permissions into the new controller code.
}
