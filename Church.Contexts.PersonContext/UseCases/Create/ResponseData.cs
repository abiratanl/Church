using Church.Contexts.SharedContext.Entities;

using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.PersonContext.UseCases.Create;

public class ResponseData : IResponseData
{
    #region Ctors
    public ResponseData(string message) => Message = message;

    public ResponseData(string message, Request request)
    {
        Message = message;
        Request = request;
    }

    #endregion

    public string Message { get; }
    public Request  Request { get; }       
}