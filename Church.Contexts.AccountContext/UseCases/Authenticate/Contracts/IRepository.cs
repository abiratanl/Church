using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.Repositories.Contracts;

namespace Church.Contexts.AccountContext.UseCases.Authenticate.Contracts;

public interface IRepository : IBaseRepository<Person>
{
    Task<User?> GetByUserNameAsync(string userName);
    Task UpdateAsync(User user);
    Task<string[]?> GetRolesAsync(Guid userId);
}