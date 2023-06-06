using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.AdmContext.UseCases.CreateNewsletter;

public class ResponseData : IResponseData
{
    #region Constructors

    public ResponseData(string message)
        => Message = message;

    public ResponseData(string message, Request? request) =>
        (Message, Request) = (message, request);

    #endregion

    #region Public Properties

    public string Message { get; set; } = string.Empty;
    public Request? Request { get; set; }

    #endregion
}