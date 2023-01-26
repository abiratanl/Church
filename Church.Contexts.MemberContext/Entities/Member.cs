using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;


public class Member : Entity
{
    #region Constructors

    /// <summary>
    /// Create a new instance of Member with default configuration
    /// </summary>
    public Member(){}

    public Member(Congregation congregation, List<Contact?> contacts, DateTime entryDate,
                bool isBaptizedHolySpirit, bool isDeleted, EMaritalStatus maritalStatus,
                List<Occurrence?> occorrences, Person person, ERole role, bool spouseIsBeliever,
                string spouseName, EStatus status, Tracker tracker) 
    {
        Congregation = congregation;
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
        Tracker = tracker;
    }

    #endregion

    #region Public Properties
    
    public Congregation Congregation { get; private set; } = null!;
    public List<Contact?> Contacts { get; set; } = null!;
    public DateTime EntryDate { get; private set; }
    public bool IsBaptizedHolySpirit { get; private set; }
    public bool IsDeleted { get; private set; }
    public EMaritalStatus MaritalStatus { get; private set; } = 0;
    public Person Person { get; private set; } = null!;
    public ERole Role { get; private set; } = 0;
    public bool? SpouseIsBeliever { get; private set; } = false;
    public string? SpouseName { get; private set; } = string.Empty;
    public EStatus Status { get; private set; } = 0;
    public Tracker Tracker { get; private set; } = null!;
    public List<Occurrence?> Occorrences { get; private set; } = null!;
    
    #endregion

    #region Methods
    
    public void ChangeInformation(EStatus status, ERole role)
    {
        Status = status;
        Role = Role;
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Pessoa excluída.");
    }
    
    #endregion
}




