namespace OpenMetrc;

public interface IFacility
{
    /// <summary>A Facility represents a building licensed for the growing, processing, and/or selling of product</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Facility>> GetFacilitiesAsync();

    /// <param name="cancellationToken">
    ///     A cancellation token that can be used by other objects or threads to receive notice of
    ///     cancellation.
    /// </param>
    /// <summary>A Facility represents a building licensed for the growing, processing, and/or selling of product</summary>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<ICollection<Facility>> GetFacilitiesAsync(CancellationToken cancellationToken);
}