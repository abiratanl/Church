using MediatR;
using Church.Contexts.SharedContext.UseCases;

namespace Church.Contexts.PersonContext.UseCases.Delete;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    #region Public Properties

    public Guid Id { get; set; }

    #endregion
}