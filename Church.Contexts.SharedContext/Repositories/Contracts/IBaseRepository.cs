using Church.Contexts.SharedContext.UseCases.Contracts;

namespace Church.Contexts.SharedContext.Repositories.Contracts;

public interface IBaseRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
{
}