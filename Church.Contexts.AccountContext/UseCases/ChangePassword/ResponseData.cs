using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.AccountContext.UseCases.ChangePassword;

public class ResponseData : IResponseData
{
    public ResponseData(string message) => Message = message;
    public string Message { get; }
}