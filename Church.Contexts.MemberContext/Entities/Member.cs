using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Member : Entity
{
    #region Contructors

    public Member() => Tracker = new Tracker("Criação do cadastro do membro");

    public Member(
        Congregation congregation, 
        List<Contact?> contacts, 
        DateTime entryDate, 
        bool isBaptizedHolySpirit, 
        bool isDeleted, 
        EMaritalStatus maritalStatus, 
        List<Occurrence?> occorrences, 
        Person person, 
        ERole role, 
        bool? spouseIsBeliever, 
        string? spouseName, 
        EStatus status)
    {
        Congregation = congregation;
        Contacts = contacts;
        EntryDate = entryDate;
        IsBaptizedHolySpirit = isBaptizedHolySpirit;
        IsDeleted = isDeleted;
        MaritalStatus = maritalStatus;
        Occorrences = occorrences;
        Person = person;
        Role = role;
        SpouseIsBeliever = spouseIsBeliever;
        SpouseName = spouseName;
        Status = status;
        Tracker = new Tracker("Criação do cadastro do membro.");
    }    

    #endregion

    #region Public Properties

    public Congregation Congregation { get; private set; } = null!;
    public List<Contact?> Contacts { get; private set; } = new List<Contact?>();
    public DateTime EntryDate { get; private set; }
    public bool IsBaptizedHolySpirit { get; private set; } = false;
    public bool IsDeleted { get; private set; } = false;
    public EMaritalStatus MaritalStatus { get; private set; } = EMaritalStatus.Married;
    public List<Occurrence?> Occorrences { get; private set; } = new List<Occurrence?>();
    public Person Person { get; private set; } = null!;
    public ERole Role { get; private set; } = ERole.Member;
    public bool? SpouseIsBeliever { get; private set; } = false;
    public string? SpouseName { get; private set; }
    public EStatus Status { get; private set; } = EStatus.Active;
    public Tracker Tracker { get; } = null!;
    #endregion

    #region Public Methods

    public void Modify(
    Congregation congregation,
    List<Contact?> contacts,
    DateTime entryDate,
    bool isBaptizedHolySpirit,
    bool isDeleted,
    EMaritalStatus maritalStatus,
    List<Occurrence?> occorrences,
    Person person,
    ERole role,
    bool? spouseIsBeliever,
    string? spouseName,
    EStatus status)
    {
        Congregation = congregation;
        Contacts = contacts;
        EntryDate = entryDate;
        IsBaptizedHolySpirit = isBaptizedHolySpirit;
        IsDeleted = isDeleted;
        MaritalStatus = maritalStatus;
        Occorrences = occorrences;
        Person = person;
        Role = role;
        SpouseIsBeliever = spouseIsBeliever;
        SpouseName = spouseName;
        Status = status;
        Tracker.Update("Informações do membro atualizadas");
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Membro excluído.");
    } 

    #endregion
}




