using Church.Contexts.SharedContext.UseCases;
using UCCreateNews = Church.Contexts.AdmContext.UseCases.CreateNewsletter;
using UCGetNews = Church.Contexts.AdmContext.UseCases.GetNewsletter;
using UCDeleteNews = Church.Contexts.AdmContext.UseCases.DeleteNewsletter;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Church.API.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class AdmController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdmController(IMediator mediator)
            => _mediator = mediator;

        [AllowAnonymous]
        [HttpPost("new-newsletter")]
        public async Task<BaseResponse<UCCreateNews.ResponseData>> CreateAsync(UCCreateNews.Request request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return result;
            }
            catch (Exception exception)
            {
                return new BaseResponse<UCCreateNews.ResponseData>(exception.Message, "7B2E5662", 500);

            }
        }
        
        [AllowAnonymous]
        [HttpPost("get-newsletter")]
        public async Task<BaseResponse<UCGetNews.ResponseData>> GetAsync(UCGetNews.Request request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return result;
            }
            catch (Exception exception)
            {
                return new BaseResponse<UCGetNews.ResponseData>(exception.Message, "8640B9E3", 500);

            }
        }
        
        [HttpDelete("delete-newsletter")]
        public async Task<BaseResponse<UCDeleteNews.ResponseData>> DeleteAsync(UCDeleteNews.Request request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return result;
            }
            catch (Exception exception)
            {
                return new BaseResponse<UCDeleteNews.ResponseData>(exception.Message, "2D7A17C1", 500);

            }
        }

    }
}
