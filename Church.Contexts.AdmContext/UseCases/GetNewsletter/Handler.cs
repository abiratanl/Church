using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.GetNewsletter.Contracts;
using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.GetNewsletter;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    private readonly  IRepository _repository;

    public Handler(IRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        var newsletter = new List<Newsletter>();
        try
        {
            newsletter =  await _repository.GetAsync(request.FirstDay, request.LastDay);
        }
        catch (Exception e)
        {
            return new BaseResponse<ResponseData>("Ocorreu um erro ao acessar o bando de dados.", "90EC5B54", 500);
        }
        if (newsletter == null)
        {
            return new BaseResponse<ResponseData>("Não foram encontrados eventos no período.");
        }
        
        return new BaseResponse<ResponseData>(new ResponseData($"Registros obtidos com sucesso.", newsletter), 201);
    }
}