using System.ComponentModel.DataAnnotations;

namespace Church.Contexts.SharedContext.Enums;

public enum EContactType
{
    [Display(Name="Celular")]
    CelPhone = 0,
    [Display(Name="E-Mail")]
    Email = 1,
    [Display(Name="Facebook")]
    Facebook = 2,
    [Display(Name="Telefone Fixo")]
    FixedPhone = 3,
    [Display(Name="Instagram")]
    Instagram = 4
}

