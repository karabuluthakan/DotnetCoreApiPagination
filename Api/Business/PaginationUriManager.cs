using System;
using Api.Business.Abstract;
using Api.Utilities.Extensions;
using Api.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace Api.Business
{
    public class PaginationUriManager : IPaginationUriService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public PaginationUriManager(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Uri GetPageUri(PaginationQuery paginationQuery)
        {
            var baseUri = httpContextAccessor.GetRequestUri();
            var route = httpContextAccessor.GetRoute();
            var endpoint = new Uri(string.Concat(baseUri, route));
            var queryUri = QueryHelpers.AddQueryString($"{endpoint}", "pageNumber", $"{paginationQuery.PageNumber}");
            queryUri = QueryHelpers.AddQueryString(queryUri, "pageSize", $"{paginationQuery.PageSize}");
            return new Uri(queryUri);
        }
    }
}