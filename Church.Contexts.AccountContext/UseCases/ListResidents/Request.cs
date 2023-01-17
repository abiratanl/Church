using MediatR;
using Church.Contexts.AccountContext.Entities;
using Church.Contexts.SharedContext.UseCases;

namespace Church.Contexts.AccountContext.UseCases.ListResidents;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public List<Resident> Residents { get; set; }
}