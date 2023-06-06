using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.GetNewsletter.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.Contexts.AdmContext.UseCases.GetNewsletter;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
        => _context = context;


    public async Task<List<Newsletter>> GetAsync(DateTime firstDay, DateTime lastDay)
        => await _context.Newsletters
            .Where(n => n.StartDate >= firstDay &&
                                n.EndDate <= lastDay &&
                                n.IsDeleted != true)
            .ToListAsync();
}