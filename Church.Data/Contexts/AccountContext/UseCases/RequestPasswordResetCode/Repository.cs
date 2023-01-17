using Church.Contexts.AccountContext.Entities;
using Church.Contexts.AccountContext.UseCases.RequestPasswordResetCode.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AccountContext.UseCases.RequestPasswordResetCode;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context) => _context = context;
    
    public async Task<bool> CheckAccountIsBlackListedAsync(string email)
        => await _context.BlackLists.AnyAsync(x => x.Email.Address == email.ToLower());

    public async Task<User?> GetUserByUsernameAsync(string email) 
        => await _context.Users.Where(x => x.Username.Address == email.ToLower()).FirstOrDefaultAsync();
}