using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.DeleteNewsletter.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AdmContext.UseCases.DeleteNewsletter;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
        => _context = context;


    public async Task<Newsletter> GetByIdAsync(Guid id)
        => await _context.Newsletters.FirstOrDefaultAsync(
            n => n.Id == id &&
                 n.IsDeleted != true);

    public async Task Delete(Newsletter newsletter)
    {
        _context.Newsletters.Update(newsletter);
        await _context.SaveChangesAsync();
    }
}