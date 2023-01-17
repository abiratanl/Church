using Church.Services.Google.ReCaptcha;

namespace Church.Services.Google.ReCaptcha.Contracts;

public interface IService
{
    Task<Response?> VerifyAsync(string reCaptchaResponse);
}