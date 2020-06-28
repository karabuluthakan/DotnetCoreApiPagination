using System;
using System.Collections.Generic;

namespace Api.Utilities.Results.Abstract
{
    public interface IPaginationResult<out T> : IResult
    {
        IReadOnlyList<T> Data { get; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
        Uri FirstPage { get; }
        Uri LastPage { get; }
        int TotalPages { get; }
        int TotalRecords { get; }
        Uri NextPage { get; }
        Uri PreviousPage { get; }
    }
}