using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.GetNewsletter;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public DateTime FirstDay { get; set; }
    public DateTime LastDay { get; set; }
}