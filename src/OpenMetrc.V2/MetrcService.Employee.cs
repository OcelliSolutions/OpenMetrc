namespace OpenMetrc.V2;

public partial class MetrcService : IEmployeeClient
{
    [MapsToApi(MetrcEndpoint.get_employees_v2)]
    Task<EmployeeMetrcWrapper> IEmployeeClient.GetEmployeesAsync(string licenseNumber, int? pageNumber, int? pageSize) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new EmployeeMetrcWrapper())
            : EmployeeClient.GetEmployeesAsync(licenseNumber, pageNumber, pageSize);

    [MapsToApi(MetrcEndpoint.get_employees_v2)]
    Task<EmployeeMetrcWrapper> IEmployeeClient.GetEmployeesAsync(string licenseNumber, int? pageNumber, int? pageSize,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult(new EmployeeMetrcWrapper())
            : EmployeeClient.GetEmployeesAsync(licenseNumber, pageNumber, pageSize, cancellationToken);
}