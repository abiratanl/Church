using Church.Contexts.SharedContext.Entities;

namespace Church.Contexts.MemberContext.Entities;

public class Leader : Entity
{
    #region Contructors

    public Leader()
    {
    }

    public Leader(Congregation congregation, DateTime endDate, Member member, DateTime startDate)
    {
        Congregation = congregation;
        EndDate = endDate;
        Member = member;
        StartDate = startDate;
    }

    #endregion

    #region Public Properties
   
    public Congregation Congregation { get; private set; } = null!;
    public DateTime EndDate { get; private set; }
    public Member Member { get; private set; } = null!;
    public DateTime StartDate { get; private set; }
    #endregion

    #region Public Methods

    public void ChangeLeader(Congregation congregation,
        DateTime endDate, Member member, DateTime startDate)
    {
        (Congregation, EndDate, Member, StartDate) = 
        (congregation, endDate, member, startDate);
    }

    #endregion
}