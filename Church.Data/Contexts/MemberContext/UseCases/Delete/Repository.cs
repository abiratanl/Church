using Church.Contexts.MemberContext.Entities;
using Church.Contexts.MemberContext.UseCases.Delete.Contracts;

namespace Church.Data.Contexts.MemberContext.UseCases.Delete;

public class Repository : IRepository
{
    #region Private Properties

    private readonly DataContext _context;

    #endregion

    #region Constructors

    public Repository(DataContext context)
        => _context = context; 

    #endregion
    public async Task UpdateAsing(Member member)
    {
        member.Delete();
        _context.Members.Update(member);
        await _context.SaveChangesAsync();
    }
}