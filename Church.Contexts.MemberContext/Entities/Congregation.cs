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
    
    [Display(Name = "Endereço")]
    public Address Address { get; private set; } = null!;
    [Display(Name = "Data da Fundação")]
    public DateTime? FundationDate { get; private set; } = null!;
    [Display(Name = "Dirigente")]
    public string Leader { get; private set; } = String.Empty;

    [Display(Name = "Data Mudança Dirigente")]
    public DateTime? LeaderExchangeDate { get; private set; } = null!;
    [Display(Name = "Nome da Congregação")]
    public string Name { get; private set; } = String.Empty;
    
    public void ChangeInformation(DateTime? fundationDate, string leader, DateTime leaderExchangeDate, string name)
    {
        FundationDate = fundationDate;
        Leader = leader;
        LeaderExchangeDate = leaderExchangeDate;
        Name = name;
    }
    
    //public void ChangeAddress(Address address) => Address = address; 
}