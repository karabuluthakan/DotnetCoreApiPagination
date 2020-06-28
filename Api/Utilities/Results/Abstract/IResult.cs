namespace Api.Utilities.Results.Abstract
{
    public interface IResult
    {
        int StatusCode { get; }
        string Message { get; }
    }
}