namespace OpenMetrc;

public interface IEmployee
{
    /// <summary>Get all employees for a license</summary>
    /// <param name="licenseNumber">The license must have `IsOwner` equal true.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Employee>> GetEmployeesAsync(string licenseNumber);

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get all employees for a license</summary>
    /// <param name="licenseNumber">The license must have `IsOwner` equal true.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Employee>> GetEmployeesAsync(string licenseNumber, CancellationToken cancellationToken);
}