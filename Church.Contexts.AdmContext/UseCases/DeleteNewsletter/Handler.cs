using Church.Contexts.AdmContext.Entities;
using Church.Contexts.AdmContext.UseCases.DeleteNewsletter.Contracts;
using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.AdmContext.UseCases.DeleteNewsletter;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    private readonly  IRepository _repository;

    public Handler(IRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        Newsletter newsletter = new Newsletter();
        try
        {
            newsletter =  await _repository.GetByIdAsync(request.Id);
        }
        catch (Exception e)
        {
            return new BaseResponse<ResponseData>("Ocorreu um erro ao acessar o bando de dados.", "90EC5B54", 500);
        }
        if (newsletter == null)
        {
            return new BaseResponse<ResponseData>("Resgistro não localizado.");
        }
        try
        {
            newsletter.Delete();
            await _repository.Delete(newsletter);
        }
        catch (Exception e)
        {
            return new BaseResponse<ResponseData>("Não foi possível excluir o registro.", "DBD9E4DC", 500);
        }
        return new BaseResponse<ResponseData>("Evento excluido com sucesso.");
    }
}