using Church.Contexts.MemberContext.Entities;
using Church.Contexts.MemberContext.UseCases.Create.Contracts;
using Church.Contexts.SharedContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.MemberContext.UseCases.Create;

public class RepositoryCongregation : IRepositoryCongregation
{
    #region Private Properties

    private readonly DataContext _context;

    #endregion

    #region Constructors

    public RepositoryCongregation(DataContext context) => _context = context;

    #endregion

    #region Public Methods

    public async  Task<Congregation> GetCongregationByIdAsync(Guid id)
        => await _context.Congregations.FirstOrDefaultAsync(c => c.Id == id);

    public async Task<bool> CheckCongregationExistsByNameAsync(string name)
            => await _context.Congregations.AnyAsync(x => x.Name == name && x.IsDeleted != true);

    public async Task CreateAsync(Congregation congregation)
    {
        await _context.Congregations.AddAsync(congregation);
        await _context.SaveChangesAsync();
    }

    #endregion
}