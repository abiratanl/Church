using Church.Contexts.AccountContext.Entities;

namespace Church.Contexts.AccountContext.UseCases.RequestPasswordResetCode.Contracts;

public interface IService
{
    Task SendPasswordVerificationCodeAsync(User user, string? returnUrl = null);
}