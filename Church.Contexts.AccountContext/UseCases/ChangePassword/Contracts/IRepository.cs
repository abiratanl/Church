using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.Repositories.Contracts;

namespace Church.Contexts.AccountContext.UseCases.ChangePassword.Contracts;

public interface IRepository : IBaseRepository<Person>
{
    Task<User?> GetStudentByUsernameAsync(string username);
    Task SaveAsync(User user);
}