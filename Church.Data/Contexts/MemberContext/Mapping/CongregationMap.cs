using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;

namespace Church.Data.Contexts.MemberContext.Mapping;

public class CongregationMap : IEntityTypeConfiguration<Congregation>
{
    public void Configure(EntityTypeBuilder<Congregation> builder)
    {
        #region Identifiers

        builder.ToTable("Congregation");
        builder.HasKey(c => c.Id);
        #endregion

        #region Properties

        builder.OwnsOne(c => c.Address)
            .Property(c => c.ZipCode)
            .HasMaxLength(20)
            .HasColumnName("ZipCode")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.Street)
            .HasMaxLength(160)
            .HasColumnName("Street")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.Number)
            .HasMaxLength(20)
            .HasColumnName("Number")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.District)
            .HasMaxLength(160)
            .HasColumnName("District")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.City)
            .HasMaxLength(160)
            .HasColumnName("City")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.State)
            .HasMaxLength(2)
            .HasColumnName("State")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.Country)
            .IsRequired(false)
            .HasMaxLength(160)
            .HasColumnName("Country")
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Address)
            .Property(c => c.Complement)
            .IsRequired(false)
            .HasMaxLength(160)
            .HasColumnName("Complement")
            .HasColumnType("NVARCHAR");
        builder.Property(c => c.EndDate)
            .HasColumnType("SMALLDATETIME");
        builder.Property(c => c.FundationDate)
            .HasColumnType("SMALLDATETIME");
        builder.Property(c => c.IsDeleted)
            .IsRequired()
            .HasColumnType("BIT");
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(160)
            .HasColumnType("NVARCHAR");
        builder.OwnsOne(c => c.Tracker)
           .Property(c => c.CreatedAt)
           .IsRequired()
           .HasColumnType("SMALLDATETIME");
        builder.OwnsOne(c => c.Tracker)
            .Property(c => c.UpdatedAt)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");
        builder.OwnsOne(c => c.Tracker)
            .Property(c => c.Notes)
            .HasMaxLength(160)
            .HasColumnType("NVARCHAR"); 
        #endregion

        // builder.HasMany(x => x.Members);
    }
}