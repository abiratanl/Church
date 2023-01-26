using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.PersonContext.UseCases.Get;

public class ResponseData : IResponseData
{
    #region Constructors

    public ResponseData(string message) => Message = message;

    public ResponseData(string message, List<Person> persons)
    {
        Message = message;
        Persons = persons;
    }

    #endregion

    #region Public Properties

    public string? Message { get; }
    public List<Person> Persons { get; private set; }

    #endregion
}