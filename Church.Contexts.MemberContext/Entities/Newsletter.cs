using Church.Contexts.SharedContext.Entities;

namespace Church.Contexts.MemberContext.Entities;

public class Newsletter : Entity
{
    #region Contructors

    public Newsletter() { }

    public Newsletter(
        string eventDescription,
        TimeSpan eventTime,
        string eventLocal,
        bool isDeleted,
        DateTime startDate,
        DateTime endDate)
    {
        EventDescription = eventDescription;
        EventTime = eventTime;
        EventLocal = eventLocal;
        IsDeleted = isDeleted;
        StartDate = startDate;
        EndDate = endDate;
    }

    #endregion

    #region Public Properties

    public string EventDescription { get; private set; } = null!;
    public TimeSpan EventTime { get; private set; }
    public string EventLocal { get; private set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }

    #endregion

    #region Public Methods

    public void Modify(
        string eventDescription,
        TimeSpan eventTime,
        string eventLocal,
        DateTime startDate,
        DateTime endDate)
    {
        EventDescription = eventDescription;
        EventTime = eventTime;
        EventLocal = eventLocal;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void Delete() => IsDeleted = true;
    #endregion
}
