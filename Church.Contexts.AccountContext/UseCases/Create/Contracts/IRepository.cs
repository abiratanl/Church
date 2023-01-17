using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.Repositories.Contracts;

namespace Church.Contexts.AccountContext.UseCases.Create.Contracts;

public interface IRepository : IBaseRepository<User>
{
    Task CreateAsync(User user);
    Task<bool> CheckAccountExistsAsync(string username);
    Task<bool> CheckAccountIsBlackListedAsync(string username);
}