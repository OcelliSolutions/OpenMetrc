namespace OpenMetrc.Builder.Domain;

public class MetrcWrapper<T> where T : class
{
    public T[]? Data { get; set; }
    public int? Total { get; set; }
    public int? TotalRecords { get; set; }
    public int? PageSize { get; set; }
    public int? RecordsOnPage { get; set; }
    public int? Page { get; set; }
    public int? CurrentPage { get; set; }
    public int? TotalPages { get; set; }
}