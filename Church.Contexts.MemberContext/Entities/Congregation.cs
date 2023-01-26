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
    protected Congregation(){}
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="address"></param>
    /// <param name="fundationDate"></param>
    /// <param name="leader"></param>
    /// <param name="leaderExchangeDate"></param>
    /// <param name="name"></param>
    public Congregation(Address address, DateTime fundationDate,
                       Guid leader, DateTime leaderExchangeDate,
                       string name) =>
        (Address, FundationDate, Leader, LeaderExchangeDate, Name) =
        (address, fundationDate, leader, leaderExchangeDate, name);
       
    #endregion

    #region Public Properties

    public Address Address { get; private set; } = null!;
    public DateTime FundationDate { get; private set; }
    public Guid Leader { get; private set; } = Guid.Empty;
    public DateTime LeaderExchangeDate { get; private set; }
    public string Name { get; private set; } = String.Empty;
    public List<Member?> Members { get; private set; } = null!;
    
    #endregion

    #region Methods

    public void ChangeInformation(DateTime fundationDate,
        Guid leader, DateTime leaderExchangeDate, string name) =>

        (FundationDate, Name) = (fundationDate, name);
    
    public void ChangeAddress(Address address) => Address = address;

    public void ChangeLeader(Guid leader, DateTime leaderExchangeDate) =>
        (Leader, LeaderExchangeDate) = (leader, leaderExchangeDate);

    #endregion
}