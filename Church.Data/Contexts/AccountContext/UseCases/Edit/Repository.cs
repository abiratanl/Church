using Church.Contexts.AccountContext.Entities;
using Church.Contexts.AccountContext.UseCases.Edit.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AccountContext.UseCases.Edit;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context) => _context = context;
    
    public async Task SaveAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUserByUsernameAsync(string username)
        => await _context.Users
            .Include(x => x.Person)
            .Where(x => x.Username.Address == username.ToLower())
            .FirstOrDefaultAsync();
}