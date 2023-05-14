using Church.Contexts.MemberContext.Entities;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.Enums;

namespace Church.Contexts.AdmContext.Entities;

public class Directorship : Entity
{
    #region Contructors

    #endregion

    #region Public Properties

    public Congregation Congregation { get; private set; } = null!;
    public Member Member { get; private set; } = null!;
    public EBoardRole BoardRole { get; private set; }
    public DateTime EndDate { get; private set; }
    public string? Notes { get; private set; }
    public DateTime StartDate { get; private set; }

    #endregion

    #region Public Methods

    #endregion
}
