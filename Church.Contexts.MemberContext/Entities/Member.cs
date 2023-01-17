using System.ComponentModel.DataAnnotations;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;
using Church.Contexts.PersonContext.Entities;

namespace Church.Contexts.MemberContext.Entities;


public class Member : Entity
{
    [Required(ErrorMessage = "O campo pessoa é obrigatório!")]
    public Person Person { get; set; }
    [Required(ErrorMessage = "O campo congregação é obrigatório!")]
    public Congregation CongregationId { get; set; }
    [Required(ErrorMessage = "O campo cargo é obrigatório!")]
    public ERole Role { get; set; }
    public EStatus Status { get; set; }
    public EMaritalStatus MaritalStatus { get; set; }
    public bool IsDeleted { get; private set; }
    public string? FatherName { get; set; }
    public string? MotherName { get; set; }
    public DateTime EntryDate { get; set; }
    public string? SpouseName { get; set; }
    public bool? SpouseIsBeliever { get; set; }
    public bool BaptizedHolySpirit { get; set; }
    public List<Occurrence?> Occorrencies { get; set; }
    public Tracker Tracker { get; set; }
    
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
}




