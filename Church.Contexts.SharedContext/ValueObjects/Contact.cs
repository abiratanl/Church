using System.ComponentModel.DataAnnotations;
using Church.Contexts.SharedContext.Enums;
using Microsoft.EntityFrameworkCore;


namespace Church.Contexts.SharedContext.ValueObjects;
[Owned]
public class Contact : ValueObject
{
    #region Constructors

    public Contact(){}

    public Contact(EContactType contactType, string description) =>
        (ContactType, Description) = (ContactType, description);

    #endregion

    #region Public Properties
    
    public EContactType ContactType { get; private set; } = 0;
    public string Description { get; private set; } = string.Empty;

    #endregion
    
}