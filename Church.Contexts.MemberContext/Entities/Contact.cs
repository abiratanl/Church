using System.ComponentModel.DataAnnotations;
using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;


namespace Church.Contexts.MemberContext.Entities;

public class Contact : Entity
{
    [Required]
    [Display(Name="Membro")]
    public Member MemberId { get; private set; }
    [Required(ErrorMessage = "Informe o tipo do contato!")]
    [Display(Name="Tipo do Contato")]
    public EContactType ContactType { get; private set; }
    [Required(ErrorMessage = "Informe a descrição do contato!")]
    [Display(Name="Contato")]
    [MaxLength(160, ErrorMessage = "O tamanho máximo do campo é 160 caracteres!")]
    public string Description { get; private set; } = String.Empty;
}