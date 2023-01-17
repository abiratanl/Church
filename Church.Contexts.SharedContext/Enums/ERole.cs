using System.ComponentModel.DataAnnotations;

namespace Church.Contexts.SharedContext.Enums;

public enum ERole
{
    [Display(Name="Diácono")]
    Deacon = 0,
    [Display(Name="Evangelista")]
    Evangelist = 1,
    [Display(Name="Membro")]
    Member = 2,
    [Display(Name="Pastor")]
    Pastor = 3,
    [Display(Name="Presbítero")]
    Elder = 4 //Presbítero
}