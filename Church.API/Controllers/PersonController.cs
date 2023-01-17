using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Church.Contexts.SharedContext.UseCases;
using UCCreate = Church.Contexts.PersonContext.UseCases.Create;
using UCDelete = Church.Contexts.PersonContext.UseCases.Delete;
using UCEdit = Church.Contexts.PersonContext.UseCases.Edit;
using UCGet = Church.Contexts.PersonContext.UseCases.Get;

namespace OldCare.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public PersonController(
        IMediator mediator)
        => _mediator = mediator;

    /// <summary>
    /// Create a new person
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost("new-person")]
    public async Task<BaseResponse<UCCreate.ResponseData>> CreateAsync(UCCreate.Request request)
    {
        try
        {
            var result = await _mediator.Send(request);
            return result;
        }
        catch (Exception e)
        {
            return new BaseResponse<UCCreate.ResponseData>(e.Message, "85398A03");
        }
    }

    /// <summary>
    /// Get all existing and not deleted people
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost("get-all")]
    public async Task<BaseResponse<UCGet.ResponseData>> GetAllAsync(UCGet.Request request)
    {
        try
        {
            var result = await _mediator.Send(request);
            return result;
        }
        catch (Exception e)
        {
            return new BaseResponse<UCGet.ResponseData>(e.Message, "CDC03992", 400);
        }
    }

    [AllowAnonymous]
    [HttpDelete("delete/{id}")]
    public async Task<BaseResponse<UCDelete.ResponseData>> DeleteAsync(Guid id)
    {
        try
        {
            var result = await _mediator.Send(new UCDelete.Request(){Id = id});
            return result;
        }
        catch (Exception e)
        {
            return new BaseResponse<UCDelete.ResponseData>(e.Message, "BF270861", 400);
        }
    }
    
    [AllowAnonymous]
    [HttpDelete("edit/{id}")]
    public async Task<BaseResponse<UCEdit.ResponseData>> UpdateAsync(Guid id)
    {
        try
        {
            var result = await _mediator.Send(new UCEdit.Request(){Id = id});
            return result;
        }
        catch (Exception e)
        {
            return new BaseResponse<UCEdit.ResponseData>(e.Message, "BF270861", 400);
        }
    }
}