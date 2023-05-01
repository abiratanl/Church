using Church.Contexts.MemberContext.Entities;
using Church.Contexts.SharedContext.Entities;

namespace Church.Contexts.MemberContext.UseCases.Create.Contracts;

public interface IRepository
{
    /// <summary>
    /// Return a person entity based in parameter passed.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Person> GetPersonByIdAsync(Guid id);

    /// <summary>
    /// Verify if person exists in Members using person id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> CheckMemberExistsByPersonIdAsync(Guid id);
    
    /// <summary>
    /// Asynchronous create a new Member.
    /// </summary>
    /// <param name="member"></param>
    /// <returns></returns>
    Task CreateAsync(Member member);
}