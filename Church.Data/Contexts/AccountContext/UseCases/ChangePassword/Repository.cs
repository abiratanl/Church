using Church.Contexts.AccountContext.Entities;
using Church.Contexts.AccountContext.UseCases.ChangePassword.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AccountContext.UseCases.ChangePassword;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context) => _context = context;

    public async Task<User?> GetStudentByUsernameAsync(string username)
        => await _context
            .Users
            .Include(x => x.Person)
            .Where(x => x.Username.Address == username.ToLower())
            .FirstOrDefaultAsync();

    public async Task SaveAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
}