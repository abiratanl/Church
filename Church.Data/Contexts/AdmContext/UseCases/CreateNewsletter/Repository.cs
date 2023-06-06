using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.CreateNewsletter.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AdmContext.UseCases.CreateNewsletter;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
        => _context = context;

    public async Task CreateAsync(Newsletter newsletter)
    {
        await _context.Newsletters.AddAsync(newsletter);
        await _context.SaveChangesAsync();
    }
        
}