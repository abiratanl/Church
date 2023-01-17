using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.Entities;



namespace Church.Contexts.MemberContext.Entities;


public class Occurrence : Entity
{
    public Member MemberId { get; set; }
    public DateTime OccurrenceDate { get; set; }
    public EOccurrenceType OccurrenceType { get; set; }
    public string? Notes { get; set; }
}