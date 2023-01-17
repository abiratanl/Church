using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.AccountContext.UseCases.Create;

public class ResponseData : IResponseData
{
    public ResponseData(string message) => Message = message;
    public string Message { get; }
}