using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.AccountContext.UseCases.Edit;

public class ResponseData : IResponseData
{
    public ResponseData(string message) => Message = message;

    public ResponseData(string message, List<Resident> residents)
    {
        Message = message;
        Residents = residents;
    }

    public string? Message { get; }
    public List<Resident> Residents { get; private set; }
}