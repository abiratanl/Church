using Church.Contexts.SharedContext.UseCases;
using MediatR;

namespace Church.Contexts.PersonContext.UseCases.Modify;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    #region Public Properties

    public Guid Id { get; set; }

    #endregion
}