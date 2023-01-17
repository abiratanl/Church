using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.ResetPassword.Contracts;

public interface IRepository
{
    Task<User?> GetUserByUsernameAsync(string username);
    Task SaveAsync(User user);
}