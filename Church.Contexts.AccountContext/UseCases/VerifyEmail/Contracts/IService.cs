using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.VerifyEmail.Contracts;

public interface IService
{
    Task SendAccountVerifiedEmailAsync(User user);
}