using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.CreateNewsletter;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public DateTime EndDate { get; set; }
    public string EventDescription { get; set; } = null!;
    public string EventLocal { get; set; } = string.Empty;
    public string EventTime { get; set; }
    public DateTime StartDate { get; set; }
}