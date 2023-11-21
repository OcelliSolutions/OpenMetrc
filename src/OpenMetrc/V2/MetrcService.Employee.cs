namespace OpenMetrc.V2;

public partial class MetrcService : IEmployeeClient
{
    [MapsToApi(MetrcEndpoint.get_employees_v2)]
    Task<EmployeeMetrcWrapper> IEmployeeClient.GetEmployeesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new EmployeeMetrcWrapper())
            : EmployeeClient.GetEmployeesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_employees_v2)]
    Task<EmployeeMetrcWrapper> IEmployeeClient.GetEmployeesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new EmployeeMetrcWrapper())
            : EmployeeClient.GetEmployeesAsync(licenseNumber, cancellationToken);
}