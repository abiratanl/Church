using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.CreateNewsletter.Contracts;
using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.CreateNewsletter;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    private readonly  IRepository _repository;

    public Handler(IRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        Newsletter newsletter = new();
        newsletter.Modify(
            request.EndDate,
            request.EventDescription,
            request.EventLocal,
            request.EventTime,
            request.StartDate);

        await _repository.CreateAsync(newsletter);

        return new BaseResponse<ResponseData>(new ResponseData($"{newsletter.EventDescription} - Evento registrado com sucesso."), 201);
    }
}