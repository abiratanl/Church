using Church.Contexts.PersonContext.Entities;
using Church.Contexts.SharedContext.Entities;
using Church.Contexts.SharedContext.Enums;

namespace Church.Contexts.AccountContext.Entities;

public class Resident : Entity
{
    #region Properties

    public Person Person { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string Father { get; set; }
    public string HealthInsurance { get; set; }
    public EMaritalStatus MaritalStatus { get; set; }
    public string Mother { get; set; }
    public string Note { get; set; }
    public string Profession { get; set; }
    public EEducationLevel EducationLevel { get; set; }
    public long SUS { get; set; }
    public long VoterRegCardNumber { get; set; }

    #endregion
    
    #region Methods

    #endregion
}

