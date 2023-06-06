using Church.Contexts.AdmContext.Entities;
namespace Church.Contexts.AdmContext.UseCases.DeleteNewsletter.Contracts;

public interface IRepository
{
    Task<Newsletter?> GetByIdAsync(Guid id);
    Task Delete(Newsletter newsletter);
}