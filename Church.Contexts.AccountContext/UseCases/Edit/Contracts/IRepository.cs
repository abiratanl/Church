using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.Edit.Contracts;

public interface IRepository
{
    Task<User?> GetUserByUsernameAsync(string username);
    Task SaveAsync(User user);
}