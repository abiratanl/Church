using Church.Contexts.MemberContext.Entities;
using Church.Contexts.MemberContext.UseCases.Create.Contracts;
using Church.Contexts.SharedContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.MemberContext.UseCases.Create;

public class Repository : IRepository
{
    #region Private Properties

    private readonly DataContext _context;

    #endregion

    #region Constructors

    public Repository(DataContext context) => _context = context;

    #endregion

    #region Public Methods

    public async  Task<Person> GetPersonByIdAsync(Guid id)
        => await _context.People.FirstOrDefaultAsync(p => p.Id == id);

    public async Task<bool> CheckMemberExistsByPersonIdAsync(Guid id)
            => await _context.Members.AnyAsync(x => x.Id == id && x.IsDeleted != true);

    public async Task CreateAsync(Member member)
    {
        await _context.Members.AddAsync(member);
        await _context.SaveChangesAsync();
    }

    #endregion
}