using Church.Contexts.AdmContext.Entities;
namespace Church.Contexts.AdmContext.UseCases.CreateNewsletter.Contracts;

public interface IRepository
{
    Task CreateAsync(Newsletter newsletter);
}