using System.Net;
using Api.Utilities.Results.Abstract;

namespace Api.Utilities.Results
{
    public class Result : IResult
    {
        public Result(HttpStatusCode statusCode)
        {
            StatusCode = (int) statusCode;
        }

        public Result(HttpStatusCode statusCode, string message) : this(statusCode)
        {
            Message = message;
        }

        public int StatusCode { get; }
        public string Message { get; }
    }
}