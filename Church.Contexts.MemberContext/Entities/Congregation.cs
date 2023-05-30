using System.ComponentModel.DataAnnotations;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Congregation : Entity
{    
    #region Contructors

    public Congregation() => Tracker = new Tracker("Criação do cadastro da congregação.");

    public Congregation(
        Address address, 
        List<Contact?> contacts, 
        DateTime endDate, 
        DateTime? fundationDate, 
        string name)
    {
        Address = address;
        Contacts = contacts;
        EndDate = endDate;
        FundationDate = fundationDate;
        Name = name;
        Tracker = new Tracker("Criação do cadastro da congregação.");
    }



    #endregion


    #region Public Propeties

    public Address Address { get; private set; } = null!;
    public List<Contact?> Contacts { get; private set; } = new List<Contact?>();
    public DateTime? EndDate { get; private set; }
    public DateTime? FundationDate { get; private set; } = null!;
    public bool IsDeleted { get; private set; }
    public string Name { get; private set; } = String.Empty;
    public List<Member?> Members { get; private set; } = new List<Member?>();
    public Tracker Tracker { get; } = null!;

    #endregion

    #region Public Methods
    public void Modify(
        DateTime endDate,
        DateTime? fundationDate,
        string name)
    {   
        EndDate = endDate;
        FundationDate = fundationDate;
        Name = name;
        Tracker.Update("Informações atualizadas.");
    }

    public void ChangeAddress(Address address) => Address = address;
    
    public void ChangeContacts(List<Contact?> contacts) => Contacts = contacts;
    
    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Congregação excluída.");
    }
     
    #endregion
}
