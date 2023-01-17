using Microsoft.EntityFrameworkCore;
using Church.Contexts.PersonContext.Entities;
using Church.Contexts.PersonContext.UseCases.Edit.Contracts;

namespace Church.Data.Contexts.PersonContext.UseCases.Edit;

public class Repository : IRepository
{
    #region Private Properties

    private readonly DataContext _context;

    #endregion

    #region Constructors

    public Repository(DataContext context) => _context = context;

    #endregion

    #region Methods

    public async Task<bool> CheckAccountExistsByIdAsync(Guid id)
        => await _context.People.AnyAsync(x => x.Id == id && x.IsDeleted != true);

    public async Task<Person> GetByIdAsync(Guid id)
        => await _context.People.FirstOrDefaultAsync(p => p.Id == id);

    public async Task UpdateAsync(Person person)
    {
       // person.IsDeleted = true;
        _context.People.Update(person);
        await _context.SaveChangesAsync();
    }

    #endregion
}