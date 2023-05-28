using MediatR;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.UseCases;
using Church.Contexts.MemberContext.Entities;

namespace Church.Contexts.MemberContext.UseCases.Create.Congregation;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    #region Address

    public string ZipCode { get; set; } = string.Empty;
    public string AddressNumber { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;

    #endregion

    public List<Contact?> Contacts { get; private set; } = new List<Contact?>();
    public DateTime EndDate { get; private set; }
    public DateTime? FundationDate { get; private set; } = null!;
    public bool IsDeleted { get; private set; }
    public string Name { get; private set; } = String.Empty;
}