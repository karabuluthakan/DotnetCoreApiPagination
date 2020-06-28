using System;
using System.Collections.Generic;
using System.Net;
using Api.Business.Abstract;
using Api.Utilities.Results;

namespace Api.Utilities.Extensions
{
    public static class PaginationExtensions
    {
        public static PaginationDataResult<T> CreatePaginationResult<T>(IReadOnlyList<T> pagedData, HttpStatusCode statusCode,
            PaginationQuery paginationQuery, int totalRecords, IPaginationUriService uriService)
        {
            var result = new PaginationDataResult<T>(pagedData, statusCode, paginationQuery.PageNumber, paginationQuery.PageSize);
            var totalPages = Convert.ToInt32(Math.Ceiling((double)totalRecords / (double)paginationQuery.PageSize));
            result.NextPage = paginationQuery.PageNumber >= 1 && paginationQuery.PageNumber < totalPages
                ? uriService.GetPageUri(new PaginationQuery(paginationQuery.PageNumber + 1, paginationQuery.PageSize))
                : null;
            result.PreviousPage = paginationQuery.PageNumber - 1 >= 1 && paginationQuery.PageNumber <= totalPages
                ? uriService.GetPageUri(new PaginationQuery(paginationQuery.PageNumber - 1, paginationQuery.PageSize))
                : null;
            result.FirstPage = uriService.GetPageUri(new PaginationQuery(1, paginationQuery.PageSize));
            result.LastPage = uriService.GetPageUri(new PaginationQuery(totalPages, paginationQuery.PageSize));
            result.TotalPages = totalPages;
            result.TotalRecords = totalRecords;

            return result;
        }
    }
}