using System;
using Api.Utilities.Results;

namespace Api.Business.Abstract
{
    public interface IPaginationUriService
    {
        public Uri GetPageUri(PaginationQuery paginationQuery);
    }
}