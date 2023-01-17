using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.Repositories.Contracts;

namespace Church.Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Contracts;

public interface IRepository : IBaseRepository<User>
{
    Task<bool> CheckAccountIsBlackListedAsync(string username);
    Task<User?> GetUserByUsernameAsync(string username);
    Task SaveAsync(User user);
}