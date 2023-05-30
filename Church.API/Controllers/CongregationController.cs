using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Church.Contexts.SharedContext.UseCases;
using UCCreate = Church.Contexts.MemberContext.UseCases.Create.CreateCongregation;
//using UCDelete = Church.Contexts.MemberContext.UseCases.Delete.Congregation;
//using UCEdit = Church.Contexts.MemberContext.UseCases.Edit.Congregation;
//using UCGet = Church.Contexts.MemberContext.UseCases.Get.Congregation;
using System;


namespace Church.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CongregationController : Controller
{
    private readonly IMediator _mediator;

    public CongregationController(IMediator mediator) => _mediator = mediator;

    [AllowAnonymous]
    [HttpPost("new-congregation")]
    public async Task<BaseResponse<UCCreate.ResponseData>> CreateAsync(UCCreate.Request request)
    {
        try
        {
            var result = await _mediator.Send(request);
            return result;
        }
        catch (Exception exception)
        {
            return new BaseResponse<UCCreate.ResponseData>(exception.Message, "3F8774F280D8");
        }
    }
}
