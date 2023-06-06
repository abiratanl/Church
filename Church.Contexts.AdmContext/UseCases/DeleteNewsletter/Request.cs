using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.DeleteNewsletter;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public Guid Id { get; set; }
}