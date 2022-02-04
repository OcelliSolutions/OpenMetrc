namespace OpenMetrc;

public partial class MetrcService : IEmployee
{
    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    Task<ICollection<Employee>> IEmployee.GetEmployeesAsync(string licenseNumber) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Employee>>(new List<Employee>())
            : UserMetrcClient.GetEmployeesAsync(licenseNumber);

    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    Task<ICollection<Employee>> IEmployee.GetEmployeesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Employee>>(new List<Employee>())
            : UserMetrcClient.GetEmployeesAsync(licenseNumber, cancellationToken);
}