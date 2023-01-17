using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.ChangeEmail.Contracts;

public interface IService
{
    Task SendAccountVerificationEmailAsync(User user);
}