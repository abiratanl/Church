using System.ComponentModel.DataAnnotations;

namespace Church.Contexts.SharedContext.Enums;
public enum EStatus
{
    [Display(Name="Afastado da Comunhão")]
    RemovedFromCommunion = 0,
    [Display(Name="Ativo")]
    Active = 1,
    [Display(Name="Desligado - Abandono")]
    DisconnectedForAbandonment = 2,
    [Display(Name="Desligado a Pedido")]
    DisconnectedOnDemand = 3,
    [Display(Name="Desligado - Falecimento")]
    DisconnectedByDeath = 4,
    [Display(Name="Desligado - Mudança")]
    DisconnetedToRelocation = 5,
    [Display(Name="Excluído")]
    Excluded = 6
}