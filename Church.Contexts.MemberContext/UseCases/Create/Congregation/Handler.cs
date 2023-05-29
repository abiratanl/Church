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

        Congregation congregation = new();

        #endregion

        #region 02. Check if congregation exists

        var result = await _repository.CheckCongregarionExistsByNameAsync(request.Name);
        if (result)
        {
            await _logService.LogAsync(
                ELogType.LocalException,
                "👤 Congregação já cadastrada.",
                "04564D20", null);
        }

        #endregion

        #region 03. Populate Aggregate Root
        
        congregation.Modify(
            request.EndDate,
            request.FundationDate,
            request.Name);

        #endregion
        
        #region 04.  Check if address is empty

        if(string.IsNullOrEmpty(request.Street) && string.IsNullOrEmpty(request.District))
            return new BaseResponse<ResponseData>(new ResponseData("", request), 201);

        #endregion
        
        #region 05. Attach address

        try
        {
            Address address = new(
                request.ZipCode,
                request.Street,
                request.AddressNumber,
                request.District,
                request.City,
                request.State,
                request.Country,
                request.Complement,
                request.Code,
                request.Notes);

            congregation.ChangeAddress(address);
        }
        catch
        {
            return new BaseResponse<ResponseData>("Não foi possível salvar o endereço.", "f00467f2");
        }

        #endregion    
        
        #region 06. Attach Contacts
        
        List<Contact> contacts = new(Request.Contacts);
        congregation.ChangeContacts(contacts);
        
        #region 07. Persist Data

        try
        {
            await _repository.CreateAsync(congregation);
        }
        catch
        {
            return new BaseResponse<ResponseData>(
                "Não foi possível salvar as informações", "16C8D89F");
        }

        #endregion
        #region 08. Return success response

        return new BaseResponse<ResponseData>(
            new ResponseData(
                $"{member.Person.Name} - Cadastro efetuado com sucesso!"),
            201);

        #endregion
    }

    #endregion

}
