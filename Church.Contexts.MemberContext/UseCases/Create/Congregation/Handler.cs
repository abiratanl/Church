using Church.Contexts.MemberContext.Entities;
using Church.Contexts.SharedContext.UseCases;
using Church.Contexts.MemberContext.UseCases.Create.Contracts;
using Church.Contexts.SharedContext.Enums;
using LogService = Church.Contexts.SharedContext.Services.Log.Contracts.IService;
using MediatR;

namespace Church.Contexts.MemberContext.UseCases.Create;

public class Handler : IRequestHandler<Request, BaseResponse<ResponseData>>
{
    #region Private Properties

    private readonly LogService _logService;
    private readonly IRepository _repository;
    
    #endregion

    #region Constructors

    public Handler(
        LogService logService,
        IRepository repository)
    {
        _logService = logService;
        _repository = repository;
    }

    #endregion

    #region Methods

    public async Task<BaseResponse<ResponseData>> Handle(Request request, CancellationToken cancellationToken)
    {
        #region 01. Create Aggregate Root

        Member member = new();

        #endregion

        #region 02. Check if member exists

        var result = await _repository.CheckMemberExistsByPersonIdAsync(request.PersonId);
        if (result)
        {
            await _logService.LogAsync(
                ELogType.LocalException,
                "👤 Membro já cadastrado.",
                "04564D20", null);
        }

        #endregion

        #region Populate Aggregate Root

        var person = await _repository.GetPersonByIdAsync(request.PersonId);
        var congregation = new Congregation();
        congregation = await _repository.GetCongregationByIdAsync(request.CongregationId);       
        member.PushCongregation(congregation);
        member.PushPerson(person);
        member.Modify(
            request.EntryDate,
            request.IsBaptizedHolySpirit,
            request.MaritalStatus,
            request.Role,
            request.SpouseIsBeliever,
            request.SpouseName,
            request.Status);

        #endregion

        

        #region Persist Data

        try
        {
            await _repository.CreateAsync(member);
        }
        catch
        {
            return new BaseResponse<ResponseData>(
                "Não foi possível salvar as informações", "16C8D89F");
        }

        #endregion
        #region 04. Return success response

        return new BaseResponse<ResponseData>(
            new ResponseData(
                $"{member.Person.Name} - Cadastro efetuado com sucesso!"),
            201);

        #endregion
    }

    #endregion

}
