﻿using Church.Contexts.AccountContext.Entities;
using Church.Data.Contexts.AccountContext.Mappings;
using Microsoft.EntityFrameworkCore;
using Church.Contexts.SharedContext.Entities;
using Church.Data.Contexts.PersonContext.Mappings;
using Church.Contexts.MemberContext.Entities;

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

    #region Member

    public DbSet<Congregation> Congregations { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Leader> Leaders { get; set; } = null!;

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

        #region Person

        builder.ApplyConfiguration(new PersonMap());
        builder.ApplyConfiguration(new DocumentMap());

        #endregion
    }
}