using Church.Contexts.MemberContext.Entities;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.Enums;

namespace Church.Contexts.AdmContext.Entities;

public class Directorship : Entity
{
    #region Contructors

    public Directorship()
    {}

    public Directorship(
        Congregation congregation,
        Member member,
        EBoardRole boardRole,
        DateTime? endDate,
        bool isDeleted,
        string? notes,
        DateTime startDate)
    {
        Congregation = congregation;
        Member = member;
        BoardRole = boardRole;
        EndDate = endDate;
        IsDeleted = isDeleted;
        Notes = notes;
        StartDate = startDate;
    }



    #endregion

    #region Public Properties

    public Congregation Congregation { get; private set; } = null!;
    public Member Member { get; private set; } = null!;
    public EBoardRole BoardRole { get; private set; }
    public DateTime? EndDate { get; private set; }
    public bool IsDeleted { get; private set; } 
    public string? Notes { get; private set; }
    public DateTime StartDate { get; private set; }

    #endregion

    #region Public Methods

    public void Modify(
        Congregation congregation,
        Member member,
        EBoardRole boardRole,
        DateTime? endDate,
        string? notes,
        DateTime startDate)
    {
        Congregation = congregation;
        Member = member;
        BoardRole = boardRole;
        EndDate = endDate;
        Notes = notes;
        StartDate = startDate;
    }

    public void Delete() => IsDeleted= true;

    #endregion
}
