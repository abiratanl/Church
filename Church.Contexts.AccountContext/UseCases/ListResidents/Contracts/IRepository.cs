using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.ListResidents.Contracts;

public interface IRepository
{
    Task<List<Resident>> GetAllResidentsOrderedByName();
}