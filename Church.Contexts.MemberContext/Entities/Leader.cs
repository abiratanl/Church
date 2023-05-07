using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Leader : Entity
{
    #region Contructors

    /// <summary>
    /// Create a new instance of Leader with default configuration
    /// </summary>
    public Leader() => Tracker = new Tracker("Criação do Cadastro do Lider.");

    /// <summary>
    /// Create a new instance of Leader with personalized configuration
    /// </summary>
    /// <param name="congregation">Congregation of the leader</param>
    /// <param name="endDate">Date of ledearship begining</param>
    /// <param name="isDeleted">Leader status</param>
    /// <param name="member">Member Global Unidque identifier</param>
    /// <param name="notes">Special information about ledearship</param>
    /// <param name="startDate">Date of the leadership end</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Leader(
        Congregation congregation, 
        DateTime endDate, 
        bool isDeleted,
        Member member,
        string notes,
        DateTime startDate)
    {
        Congregation = congregation;
        EndDate = endDate;
        IsDeleted= isDeleted;
        Member = member;
        Notes = notes;
        StartDate = startDate;
    }

    #endregion

    #region Public Properties
   
    public Congregation Congregation { get; private set; } = null!;
    public DateTime EndDate { get; private set; }
    public bool IsDeleted { get; private set; }
    public Member Member { get; private set; } = null!;
    public string? Notes { get; private set; }
    public DateTime StartDate { get; private set; }
    public Tracker Tracker { get; } = null!;
    #endregion

    #region Public Methods

    public void Modify(
        Congregation congregation,
        DateTime endDate, 
        Member member,
        string? notes,
        DateTime startDate)
    {
        Congregation= congregation;
        EndDate= endDate;   
        Member= member;
        Notes = notes;
        StartDate= startDate;
        Tracker.Update("Informações atualizadas.");
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Lider excluído.");
    }

    #endregion
}