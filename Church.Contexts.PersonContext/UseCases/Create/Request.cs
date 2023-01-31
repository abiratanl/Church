using Church.Contexts.SharedContext.UseCases;
using MediatR;
using Church.Contexts.SharedContext.ValueObjects;
using Church.Contexts.SharedContext.Enums;

namespace Church.Contexts.PersonContext.UseCases.Create;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    #region Address

    public string City { get; set; } = string.Empty;
    public string? Code { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string? Country { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string? Notes { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;

    #endregion

    public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    public string Citizenship { get; set; } = string.Empty;
    public List<Document?> Documents { get; set; } = new();
    public string? FatherName { get; set; } = string.Empty;
    public string FirstName { get; set; } = null!;
    public string FullNumber { get; set; } = string.Empty;
    public EGender Gender { get; set; }
    public string LastName { get; set; } = null!;
    public string? MotherName { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public string Obs { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;

    public string returnUrl { get; set; } = string.Empty;
}