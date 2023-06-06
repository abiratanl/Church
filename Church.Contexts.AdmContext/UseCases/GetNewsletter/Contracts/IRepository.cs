using Church.Contexts.AdmContext.Entities;
namespace Church.Contexts.AdmContext.UseCases.GetNewsletter.Contracts;

public interface IRepository
{
    Task<List<Newsletter?>> GetAsync(DateTime firstDay, DateTime lastDay);
}