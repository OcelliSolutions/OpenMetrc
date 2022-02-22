namespace OpenMetrc;

public partial class MetrcService : IEmployeeClient
{
    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    Task<ICollection<Employee>?> IEmployeeClient.GetEmployeesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Employee>?>(new List<Employee>())
            : EmployeeClient.GetEmployeesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    Task<ICollection<Employee>?> IEmployeeClient.GetEmployeesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Employee>?>(new List<Employee>())
            : EmployeeClient.GetEmployeesAsync(licenseNumber, cancellationToken);
}