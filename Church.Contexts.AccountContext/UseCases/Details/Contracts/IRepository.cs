using Church.Contexts.AccountContext.UseCases.Details.Models;

namespace Church.Contexts.AccountContext.UseCases.Details.Contracts;

public interface IRepository
{
    Task<DetailsModel?> GetUserByUsernameAsync(string username);
}