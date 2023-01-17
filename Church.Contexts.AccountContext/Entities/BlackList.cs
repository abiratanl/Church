using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.AccountContext.Entities;

public class BlackList : Entity
{
    protected BlackList()
    {
    }

    public BlackList(string email)
    {
        Email = email;
        Tracker = new();
    }

    public Email Email { get; } = null!;
    public Tracker Tracker { get; } = null!;
}