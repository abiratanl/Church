using Church.Contexts.SharedContext.Entities;
using Church.Contexts.PersonContext.UseCases.Get.Contracts;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Services.Log.Contracts;
using Church.Contexts.SharedContext.UseCases;
using MediatR;


namespace Church.Contexts.PersonContext.UseCases.Get;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    #region Private Properties

    private readonly IService _logService;
    private readonly IRepository _repository;

    #endregion

    #region Constructors

    public Handler(
        IService logService,
        IRepository repository)
    {
        _logService = logService;
        _repository = repository;
    }

    #endregion

    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        #region Create Aggregate Root

        var persons = new List<Person>();
        
        #endregion

        #region Populate list

        try
        {
            persons = await _repository.GetAllAsync(request.Skip, request.Take);
        }
        catch (Exception ex)
        {
            await _logService.LogAsync(ELogType.LocalException, "❌ Ocorreu um erro ao carregar os registros.", "400168D3", ex.Message);
            return new BaseResponse<ResponseData>("Ocorreu um erro ao carregar os registros.", "400168D3");
        }

        #endregion
        
        
        #region Return Success Message

        await _logService.LogAsync(ELogType.LocalApplicationEvent, "📃 Registros obtidos com sucesso", "Pessoas", "");
        return new BaseResponse<ResponseData>(new ResponseData($"Registros obtidos com sucesso.", persons), 201);

        #endregion
    }
}