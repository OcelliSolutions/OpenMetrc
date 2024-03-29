﻿namespace OpenMetrc.V1;

public partial class MetrcService : IEmployeeClient
{
    [MapsToApi(MetrcEndpoint.get_employees_v1)]
    Task<ICollection<Employee>?> IEmployeeClient.GetEmployeesAsync(string licenseNumber,
        CancellationToken cancellationToken) =>
        !CheckEndpointAvailability(MethodBase.GetCurrentMethod())
            ? Task.FromResult<ICollection<Employee>?>(new List<Employee>())
            : EmployeeClient.GetEmployeesAsync(licenseNumber, cancellationToken);
}