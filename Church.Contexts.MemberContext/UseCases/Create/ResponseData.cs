using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.MemberContext.UseCases.Create;

public class ResponseData :IResponseData
{
    #region Constructors

    public ResponseData(string message) => Message = message;

    public ResponseData(string message, Request request)
    {
        Message = message;
        Request = request;
    }

    #endregion

    #region Public Properties

    public string  Message { get; }
    public Request Request { get; }

    #endregion
}