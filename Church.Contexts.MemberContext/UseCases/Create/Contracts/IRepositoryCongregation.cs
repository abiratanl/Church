using Church.Contexts.MemberContext.Entities;
using Church.Contexts.SharedContext.Entities;

namespace Church.Contexts.MemberContext.UseCases.Create.Contracts;

public interface IRepositoryCongregation
{   
    /// <summary>
    /// Return a congretarion entity based in parameter passed.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Congregation?> GetCongregationByIdAsync(Guid id);

    /// <summary>
    /// Verify if congregation exists in Congregations using name.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    Task<bool> CheckCongregationExistsByNameAsync(string name);
    
    /// <summary>
    /// Asynchronous create a new Congregation.
    /// </summary>
    /// <param name="congregation"></param>
    /// <returns></returns>
    Task CreateAsync(Congregation congregation);
}