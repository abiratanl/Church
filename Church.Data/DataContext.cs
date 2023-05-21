using Church.Contexts.AccountContext.Entities;
using Church.Data.Contexts.AccountContext.Mappings;
using Microsoft.EntityFrameworkCore;
using Church.Contexts.SharedContext.Entities;
using Church.Data.Contexts.PersonContext.Mappings;
using Church.Contexts.MemberContext.Entities;
using Church.Data.Contexts.MemberContext.Mapping;
using Church.Contexts.AdmContext.Entities;
using Church.Data.Contexts.AdmContext.Mapping;

namespace Church.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    #region Account
    public DbSet<BlackList> BlackLists { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;

    #endregion

    #region Adm

    public DbSet<Newsletter> Newsletters { get; set; } = null!;
    public DbSet<Directorship> Directorships { get; set; } = null!;

    #endregion

    #region Member

    public DbSet<Congregation> Congregations { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Leader> Leaders { get; set; } = null!;
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Occurrence> Occurrences { get; set; } = null!;


    #endregion

    #region Person

    public DbSet<Person> People { get; set; } = null!;
    public DbSet<Document> Documents { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder builder)
    {       
        #region Account

        builder.HasDefaultSchema("backoffice");
        builder.ApplyConfiguration(new BlackListMap());
        builder.ApplyConfiguration(new UserMap());
        builder.ApplyConfiguration(new RoleMap());
        builder.ApplyConfiguration(new UserRoleMap());

        #endregion

        #region Adm

        builder.ApplyConfiguration(new NewsletterMap());
        builder.ApplyConfiguration(new DirectorshipMap());

        #endregion

        #region Person

        builder.ApplyConfiguration(new PersonMap());
        builder.ApplyConfiguration(new DocumentMap());

        #endregion

        #region Member

        builder.ApplyConfiguration(new MemberMap());
        builder.ApplyConfiguration(new CongregationMap());
        builder.ApplyConfiguration(new ContactMap());
        builder.ApplyConfiguration(new OccurrenceMap());
        builder.ApplyConfiguration(new LeaderMap());

        #endregion
    }
}