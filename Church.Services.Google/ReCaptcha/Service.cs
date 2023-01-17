using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Church.Contexts.SharedContext;
using Church.Services.Google.ReCaptcha.Contracts;
using Church.Services.Google.ReCaptcha.Exceptions;

namespace Church.Services.Google.ReCaptcha;

public class Service : IService
{
    public async Task<Response?> VerifyAsync(string reCaptchaResponse)
    {
        using var client = new HttpClient();

        var url =
            $"{Configuration.Google.ReCaptcha.ApiUrl}?secret={Configuration.Google.ReCaptcha.SiteSecret}&response={reCaptchaResponse}";
        
        var request = new HttpRequestMessage(HttpMethod.Get, url);

        try
        {
            var result = await client.SendAsync(request);
            return await result.Content.ReadFromJsonAsync<Response>();
        }
        catch
        {
            throw new GoogleCaptchaException("Não foi possível validar o ReCaptcha");
        }
    }
}