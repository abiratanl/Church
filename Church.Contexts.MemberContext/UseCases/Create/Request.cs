using MediatR;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.UseCases;

namespace Church.Contexts.MemberContext.UseCases.Create;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public Guid PersonId { get; set; } = new();
    public Guid CongregationId { get; set; }
    public DateTime EntryDate { get; set; } = DateTime.UtcNow;
    public bool IsBaptizedHolySpirit { get; set; }
    public bool IsDeleted { get; set; }
    public EMaritalStatus MaritalStatus { get; set; }
    public ERole Role { get; set; }
    public bool SpouseIsBeliever { get; set; }
    public string SpouseName { get; set; } = string.Empty;
    public EStatus Status { get; set; }
    public string returnUrl { get; set; } = string.Empty;
}