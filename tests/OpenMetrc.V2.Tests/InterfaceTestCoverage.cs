using System.Reflection;

namespace OpenMetrc.V2.Tests;

public class InterfaceTestCoverage
{
    /*
    [Theory]
    [InlineData(typeof(ICaregiverClient), typeof(CaregiverTests))]
    [InlineData(typeof(IEmployeeClient), typeof(EmployeeTests))]
    [InlineData(typeof(IFacilityClient), typeof(FacilityTests))]
    [InlineData(typeof(IHarvestClient), typeof(HarvestTests))]
    [InlineData(typeof(IItemClient), typeof(ItemTests))]
    [InlineData(typeof(ILabTestClient), typeof(LabTestTests))]
    [InlineData(typeof(ILocationClient), typeof(LocationTests))]
    [InlineData(typeof(IPackageClient), typeof(PackageTests))]
    [InlineData(typeof(IPatientCheckInClient), typeof(PatientCheckInTests))]
    [InlineData(typeof(IPatientClient), typeof(PatientTests))]
    [InlineData(typeof(IPlantClient), typeof(PlantTests))]
    [InlineData(typeof(IPlantBatchClient), typeof(PlantBatchTests))]
    [InlineData(typeof(IProcessingClient), typeof(ProcessingTests))]
    [InlineData(typeof(ISaleClient), typeof(SaleTests))]
    [InlineData(typeof(IStrainClient), typeof(StrainTests))]
    [InlineData(typeof(ITransferClient), typeof(TransferTests))]
    [InlineData(typeof(IUnitOfMeasureClient), typeof(UnitOfMeasureTests))]
    // Add more interfaces and their corresponding test classes as needed
    public void EnsureGetInterfaceMethodsAreTested(Type interfaceType, Type testClassType)
    {
        // Gather all methods from the interface
        var interfaceMethods = interfaceType.GetMethods();

        // Gather all test methods from the test class
        var testMethods = testClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
            .Where(m => m.GetCustomAttributes(typeof(FactAttribute), true).Any() ||
                        m.GetCustomAttributes(typeof(TheoryAttribute), true).Any())
            .ToList();

        // Filter interface methods based on criteria
        var filteredInterfaceMethods = interfaceMethods
            .Where(m => m.Name.StartsWith("Get"))
            .Where(m => {
                var parameters = m.GetParameters();
                return (parameters.Length == 0 ||
                        (parameters.Length == 1
                         && (parameters[0].ParameterType == typeof(string) ||
                             parameters[0].ParameterType == typeof(DateTime))))
                       && parameters.All(p => p.ParameterType != typeof(CancellationToken));
            })
            .ToList();

        // List to hold any methods that are missing tests
        var missingTests = filteredInterfaceMethods
            .Where(interfaceMethod => !testMethods.Any(testMethod =>
                testMethod.Name.Equals($"{interfaceMethod.Name}_AdditionalPropertiesAreEmpty_ShouldPass",
                    StringComparison.OrdinalIgnoreCase) ||
                testMethod.Name.Equals($"{interfaceMethod.Name}_ValidEndpoint_ShouldPass",
                    StringComparison.OrdinalIgnoreCase)))
            .Select(m => m.Name)
            .ToList();

        // Assert that there are no missing tests
        Assert.True(!missingTests.Any(),
            $"Missing tests for the following methods in {interfaceType.Name}: {string.Join(", ", missingTests.Distinct())}");
    }
    */
    [Fact]
    public void EnsureAllEnumValuesAreAssignedToMethods()
    {
        var usedEnumsCount = new Dictionary<MetrcEndpoint, int>();

        var interfaceType = typeof(MetrcService);
        var methods = interfaceType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                               BindingFlags.Static);

        foreach (var method in methods)
        {
            var attribute = method.GetCustomAttribute<MapsToApiAttribute>();
            if (attribute == null) continue;
            usedEnumsCount.TryAdd(attribute.Endpoint, 0);
            usedEnumsCount[attribute.Endpoint]++;
        }

        var enumValues = Enum.GetValues(typeof(MetrcEndpoint)).Cast<MetrcEndpoint>();
        var incorrectlyUsedEnums = enumValues
            .Where(ev => ev.ToString().Contains("v2"))
            .Where(ev => usedEnumsCount.GetValueOrDefault(ev) != 2)
            .ToList();

        Assert.True(incorrectlyUsedEnums.Count == 0,
            $"The following enum values are not correctly used (should be used exactly twice): {string.Join(", ", incorrectlyUsedEnums)}");
    }
}