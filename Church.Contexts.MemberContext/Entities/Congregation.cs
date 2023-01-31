using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Congregation : Entity
{
    #region Constructors

    /// <summary>
    /// Create a new instance of Congregation with default configuration
    /// </summary>
    public Congregation()
    {
    }

    /// <summary>
    /// Create a new instance of Congregation with defined configuration
    /// </summary>
    /// <param name="address"></param>
    /// <param name="fundationDate"></param>
    /// <param name="leader"></param>
    /// <param name="leaderExchangeDate"></param>
    /// <param name="name"></param>
    public Congregation(Address address,
        DateTime fundationDate, IEnumerable<Member>? members)
    {
        Address = address;
        FundationDate = fundationDate;
        Members = members;
    }
       
    #endregion

    #region Public Properties

    public Address Address { get; private set; } = null!;
    public DateTime FundationDate { get; private set; }
    public string Name { get; private set; } = String.Empty;
    public IEnumerable<Member>? Members { get;}
    
    #endregion

    #region Public Methods

    public void ChangeInformation(DateTime fundationDate, string name) =>

        (FundationDate, Name) = (fundationDate, name);
    
    public void ChangeAddress(Address address) => Address = address;

    #endregion
}