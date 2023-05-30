using MediatR;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.UseCases;
using Church.Contexts.MemberContext.Entities;

namespace Church.Contexts.MemberContext.UseCases.Create.CreateCongregation;

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
        
    public DateTime EndDate { get; set; }
    public DateTime? FundationDate { get; set; } = null!;
    public string Name { get; set; } = String.Empty;
    public List<Contact>? Contacts { get; set; } = new List<Contact>();
    public string returnUrl { get; set; } = string.Empty;
}