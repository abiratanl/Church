using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Church.Contexts.SharedContext.UseCases;
using UCCreate = Church.Contexts.MemberContext.UseCases.Create;
using UCCreateCong = Church.Contexts.MemberContext.UseCases.Create.CreateCongregation;
using UCDelete = Church.Contexts.MemberContext.UseCases.Delete;
using UCEdit = Church.Contexts.MemberContext.UseCases.Edit;
using UCGet = Church.Contexts.MemberContext.UseCases.Get;

namespace Church.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MemberController
    {
        private readonly IMediator _mediator;

        public MemberController(
            IMediator mediator)
            => _mediator = mediator;

        [AllowAnonymous]
        [HttpPost("new-member")]
        public async Task<BaseResponse<UCCreate.ResponseData>> CreateAsync(UCCreate.Request request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return result;
            }
            catch (Exception e) 
            {
                return new BaseResponse<UCCreate.ResponseData>(e.Message, "2E7663E179C7");
            }
        }
    }
}
