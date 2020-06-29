namespace Api.Utilities.Results.Abstract
{
    public interface IPaginationQuery
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}