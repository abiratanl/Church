using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.Create.Contracts;

public interface IService
{
    Task SendEmailVerificationCodeAsync(User user, string? returnUrl);
}