using Church.Contexts.AdmContext.Entities;
using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.AdmContext.UseCases.GetNewsletter;

public class ResponseData : IResponseData
{
    #region Constructors

    public ResponseData(string message)
        => Message = message;

    public ResponseData(string message, List<Newsletter?> newsletters) =>
        (Message, Newsletters) = (message, newsletters);

    #endregion

    #region Public Properties

    public string Message { get; set; } = string.Empty;
    public List<Newsletter?> Newsletters { get; set; }

    #endregion
}