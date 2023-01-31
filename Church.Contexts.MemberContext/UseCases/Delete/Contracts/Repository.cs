using Church.Contexts.MemberContext.Entities;

namespace Church.Contexts.MemberContext.UseCases.Delete.Contracts;

public interface IRepository
{
    /// <summary>
    /// Delete a member updating IsDelete property to true
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task UpdateAsing(Member member);
}