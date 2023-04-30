using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Contact : Entity
{  
    #region Contructors

    /// <summary>
    /// Create a new instance of Occurrence with default configuration
    /// </summary>
    public Contact() => Tracker = new Tracker("Criação do cadastro de contatos.");

    /// <summary>
    /// Create a new instance of Person with personalized configuration
    /// </summary>
    /// <param name="contactType">Contact type (email, phone, etc)</param>
    /// <param name="description">Contact description</param>
    /// <param name="isDeleted">Contact status</param>
    /// <param name="memberId">Member Global Unique Identification</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Contact(
        EContactType contactType,
        string description,
        bool isDeleted,
        Member memberId)
    {
        ContactType = contactType;
        Description = description;
        IsDeleted = isDeleted;
        MemberId = memberId;
        Tracker = new Tracker("Criação do cadastro de ocorrências.");
    }

    #endregion
    #region Public Properties


    public EContactType ContactType { get; private set; }
    public string Description { get; private set; } = String.Empty;
    public bool IsDeleted { get; private set; }
    public Member MemberId { get; private set; }
    public Tracker Tracker { get; } = null!;

    #endregion

    #region Public Methods

    /// <summary>
    /// Change the contact information
    /// </summary>
    /// <param name="contactType">Type of contact</param>
    /// <param name="description">Description of contact</param>
    /// <param name="memberId">Member Global Unique Identifier</param>
    /// <returns>void</returns>
    public void Modify(
        EContactType contactType,
        string description,
        Member memberId)
    {
        ContactType = contactType;
        Description = description;
        MemberId = memberId;
        Tracker.Update("Informações atualizadas.");
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Contato excluído.");
    }

    #endregion

}