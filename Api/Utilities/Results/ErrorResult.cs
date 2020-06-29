using System.Collections.Generic;
using System.Net;
using Api.Utilities.Results.Abstract;

namespace Api.Utilities.Results
{
    public class ErrorResult : IResult
    {
        public int StatusCode { get; }
        public string Message { get; set; }
        public IDictionary<string, string> Errors { get; set; }

        public ErrorResult(HttpStatusCode statusCode)
        {
            this.StatusCode = (int) statusCode;
            this.Message = "An error occured";
        }

        public ErrorResult(HttpStatusCode statusCode, IDictionary<string, string> errors) : this(statusCode)
        {
            this.Errors = errors;
        } 
    }
}