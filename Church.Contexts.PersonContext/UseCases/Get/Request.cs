using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.PersonContext.UseCases.Get;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public int Skip { get; set; }
    public int Take { get; set; }
}