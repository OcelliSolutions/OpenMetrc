namespace OpenMetrc;

public interface IUnitOfMeasure
{
    /// <summary>Get all units of measures</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<UnitOfMeasure>> GetUnitsOfMeasureAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>Get all units of measures</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<UnitOfMeasure>> GetUnitsOfMeasureAsync(CancellationToken cancellationToken);
}