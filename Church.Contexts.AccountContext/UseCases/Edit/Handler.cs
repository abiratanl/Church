using Church.Contexts.AccountContext.Entities;
using Church.Contexts.AccountContext.UseCases.Edit.Contracts;
using Church.Contexts.SharedContext.Extensions;
using Church.Contexts.SharedContext.Services.Log.Contracts;
using Church.Contexts.SharedContext.UseCases;
using Church.Contexts.SharedContext.ValueObjects;
using MediatR;
using Church.Contexts.SharedContext.Enums;

namespace Church.Contexts.AccountContext.UseCases.Edit;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    #region Private Properties

    private readonly IRepository _repository;
    private readonly IService _logService;

    #endregion

    #region Constructors

    public Handler(
        IRepository repository,
        IService logService)
    {
        _repository = repository;
        _logService = logService;
    }

    #endregion

    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        #region 01. Validar CPF do aluno
        
        // Document cpf = request.Document;
        //
        // if (!cpf.IsCpf())
        //     return new BaseResponse<ResponseData>("Cpf inválido", "b95ad2df");

        #endregion
        
        #region 02. Recuperar aluno por email

        User? user;

        try
        {
            user = await _repository.GetUserByUsernameAsync(request.Email);
        }
        catch (Exception ex)
        {
            return new BaseResponse<ResponseData>(ex);
        }

        #endregion

        #region 03. Verificar se o aluno existe

        if (user is null)
            return new BaseResponse<ResponseData>("Conta não encontrada", "Student", 404);

        #endregion

        #region 04. Atribuir valores da requisição ao aluno

        try
        {
            // user.Person.ChangeInformation(
            //     request.BirthDate,
            //     request.FirstName,
            //     request.LastName,
            //     ,
            //     "");
        }
        catch
        {
            return new BaseResponse<ResponseData>("Não foi possível salvar as alterações!", "7b2d523d");
        }
        
        #endregion

        #region 05. Atribuir telefone ao aluno

        try
        {
            if (request.Phone != null)
                user.Person.ChangePhone(request.Phone.ToNumbersOnly());
        }
        catch
        {
            return new BaseResponse<ResponseData>("Não foi possível salvar as alterações!", "38803002");
        }

        #endregion

        #region 06. Persistir os dados no banco

        try
        {
            await _repository.SaveAsync(user);
        }
        catch
        {
            await _logService.LogAsync(ELogType.LocalException, 
                "⚠ Não foi possível realizar as alterações de informação do aluno ({request.Email}).");
            return new BaseResponse<ResponseData>("Não foi possível salvar as alterações!", "ddb9f50d");
        }

        #endregion

        #region 05. Retornar mensagem de sucesso

        return new BaseResponse<ResponseData>(new ResponseData("Alterações salvas com sucesso."));

        #endregion
    }
}