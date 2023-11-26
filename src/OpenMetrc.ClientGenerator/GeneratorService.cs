using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace OpenMetrc.ClientGenerator;

internal static class GeneratorService
{
    internal static async Task CreateClientClass(string filename)
    {
        var version = FileService.GetVersionFromFilename(filename);
        version = version.ToUpper();
        var document = OpenApiYamlDocument.FromFileAsync(filename).Result;


        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "{controller}Client",
            OperationNameGenerator = new MultipleClientsFromFirstTagAndOperationIdGenerator(),
            GenerateClientInterfaces = true,
            GenerateOptionalParameters = true,
            AdditionalNamespaceUsages = new[] { "System.Text.Json" },
            CSharpGeneratorSettings =
            {
                Namespace = $"OpenMetrc.{version}",
                JsonLibrary = CSharpJsonLibrary.SystemTextJson,
                GenerateOptionalPropertiesAsNullable = true,
                GenerateNullableReferenceTypes = true,
                GenerateDefaultValues = true,
                GenerateDataAnnotations = true,
                ClassStyle = CSharpClassStyle.Poco,
                DateType = "DateOnly",
                DateTimeType = "DateTimeOffset"
            }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        await File.WriteAllTextAsync($"../../../../../src/OpenMetrc.{version}/MetrcBaseClient.cs", code);
    }
}