using Church.Contexts.MemberContext.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping;

public class MemberMap : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Member");

        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Person);
        
        builder.Property(x => x.EntryDate)
            .HasColumnType("SMALLDATETIME");

        builder.Property(x => x.IsBaptizedHolySpirit)
            .IsRequired()
            .HasColumnType("BIT");

        builder.Property(x => x.IsDeleted)
            .IsRequired()
            .HasColumnType("BIT");

        builder.Property(x => x.MaritalStatus)
            .IsRequired()
            .HasColumnType("TINYINT");
        
        builder.Property(x => x.Role)
            .IsRequired()
            .HasColumnType("TINYINT");

        builder.Property(x => x.Status)
            .IsRequired()
            .HasColumnType("TINYINT");

        builder.Property(x => x.SpouseIsBeliever)
            .HasColumnType("BIT");

        builder.Property(x => x.SpouseName)
            .HasMaxLength(160)
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Tracker)
            .Property(x => x.CreatedAt)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");

        builder.OwnsOne(x => x.Tracker)
            .Property(x => x.UpdatedAt)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");

        builder.OwnsOne(x => x.Tracker)
            .Property(x => x.Notes)
            .HasMaxLength(160)
            .HasColumnType("NVARCHAR");

        builder.OwnsMany(x => x.Occorrences);
        
        builder.OwnsMany(x => x.Contacts);
    }
}
