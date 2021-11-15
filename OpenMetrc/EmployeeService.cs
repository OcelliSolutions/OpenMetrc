namespace OpenMetrc;
public class EmployeeService : BaseService//, IEmployeeClient
{
    public EmployeeService(string state, string softwareApiKey, string userApiKey, bool isSandbox, bool returnEmptyOnNotSupported = false) : base(state, softwareApiKey, userApiKey, isSandbox, returnEmptyOnNotSupported)
    {
    }

    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    public Task<ICollection<Employee>> GetEmployeesAsync(string licenseNumber)
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return Task.FromResult<ICollection<Employee>>(new List<Employee>());
        return GetEmployeesAsync(licenseNumber, CancellationToken.None);
    }

    [MapsToApi(MetrcEndpoint.get_employees_v1_)]
    public async Task<ICollection<Employee>> GetEmployeesAsync(string licenseNumber, CancellationToken cancellationToken)
    {
        if (!CheckEndpointAvailability(MethodBase.GetCurrentMethod())) return new List<Employee>();
        return await ApiKey.EmployeeClient.GetEmployeesAsync(licenseNumber, cancellationToken);
    }
}
