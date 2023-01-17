using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Contracts;

public interface IService
{
    Task ResendEmailVerificationCodeAsync(User user, string? returnUrl = null);
}