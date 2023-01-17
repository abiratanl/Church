using Church.Contexts.SharedContext.Entities;
namespace Church.Contexts.AccountContext.Entities;

public class Role : Entity
{
    protected Role()
    {
    }

    public string Name { get; } = string.Empty;

    public static implicit operator string(Role role) => role.Name;

    public override string ToString() => Name;
}