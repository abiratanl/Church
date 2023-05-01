using System.ComponentModel.DataAnnotations;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.MemberContext.Entities;

public class Congregation : Entity
{
    // Obrigatório para o EF funcionar
    protected Congregation()
    {
        
    }
    public Congregation(Address address, DateTime? fundationDate, string leader, DateTime leaderExchangeDate, string name)
    {
        Address = address;
        FundationDate = fundationDate;
        Leader = leader;
        LeaderExchangeDate = leaderExchangeDate;
        Name = name;
    }
    
    
    public Address Address { get; private set; } = null!;
    public DateTime? FundationDate { get; private set; } = null!;
    public string Leader { get; private set; } = String.Empty;
    public DateTime? LeaderExchangeDate { get; private set; } = null!;
    public string Name { get; private set; } = String.Empty;
    public List<Member> Members { get; set; }

    public void ChangeInformation(DateTime? fundationDate, string leader, DateTime leaderExchangeDate, string name)
    {
        FundationDate = fundationDate;
        Leader = leader;
        LeaderExchangeDate = leaderExchangeDate;
        Name = name;
    }
    
    //public void ChangeAddress(Address address) => Address = address; 
}