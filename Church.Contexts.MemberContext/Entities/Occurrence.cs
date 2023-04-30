using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;


public class Occurrence : Entity
{
    #region Contructors

    /// <summary>
    /// Create a new instance of Occurrence with default configuration
    /// </summary>
    public Occurrence() => Tracker = new Tracker("Criação do cadastro de ocorrências.");

    /// <summary>
    /// Create a new instance of Person with personalized configuration
    /// </summary>
    /// <param name="occurrenceDate">Date of occurrence</param>
    /// <param name="occurrenceType">Occurrence description</param>
    /// <param name="isDeleted">Occurrence status</param>
    /// <param name="memberId">Member Global Unique Identification</param>
    /// <param name="notes">Special information about occurrence</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Occurrence(
        DateTime occurrenceDate, 
        EOccurrenceType occurrenceType, 
        bool isDeleted, 
        Member memberId, 
        string notes)
    {
        OccurrenceDate = occurrenceDate;
        OccurrenceType = occurrenceType;
        IsDeleted = isDeleted;
        MemberId = memberId;
        Notes = notes;
        Tracker = new Tracker("Criação do cadastro de ocorrências.");
    }

    #endregion
    #region Public Properties

    public bool IsDeleted { get; private set; }
    public Member MemberId { get; private set; }
    public DateTime OccurrenceDate { get; private set; }
    public EOccurrenceType OccurrenceType { get; private set; }
    public string? Notes { get; private set; }
    public Tracker Tracker { get; } = null!;

    #endregion

    #region Public Methods

    /// <summary>
    /// Change the occurrence information
    /// </summary>
    /// <param name="occurrenceDate">Date of occurrence</param>
    /// <param name="occurrenceType">Type of occurrence</param>
    /// <param name="memberId">Member Global Unique Identifier</param>
    /// <returns>void</returns>
    public void Modify(
        DateTime occurrenceDate,
        EOccurrenceType occurrenceType,
        Member memberId,
        string notes)
    {
        OccurrenceDate = occurrenceDate;
        OccurrenceType = occurrenceType;
        MemberId = memberId;
        Notes = notes;
        Tracker.Update("Informações atualizadas.");
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Ocorrência excluída.");
    }

    #endregion
}