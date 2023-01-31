using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;

namespace Church.Data.Contexts.MemberContext.Mapping;

public class CongregationMap : IEntityTypeConfiguration<Congregation>
{
    public void Configure(EntityTypeBuilder<Congregation> builder)
    {
        builder.ToTable("Congregation");
        
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Address);
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.ZipCode)
            .HasMaxLength(20)
            .HasColumnName("ZipCode")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.Street)
            .HasMaxLength(160)
            .HasColumnName("Street")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.Number)
            .HasMaxLength(20)
            .HasColumnName("Number")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.District)
            .HasMaxLength(160)
            .HasColumnName("District")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.City)
            .HasMaxLength(160)
            .HasColumnName("City")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.State)
            .HasMaxLength(2)
            .HasColumnName("State")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.Country)
            .IsRequired(false)
            .HasMaxLength(160)
            .HasColumnName("Country")
            .HasColumnType("NVARCHAR");
        
        builder.OwnsOne(x => x.Address)
            .Property(x => x.Complement)
            .IsRequired(false)
            .HasMaxLength(160)
            .HasColumnName("Complement")
            .HasColumnType("NVARCHAR");
        
        builder.Property(x => x.FundationDate)
            .HasColumnType("SMALLDATETIME");
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(160)
            .HasColumnType("NVARCHAR");

        builder.HasMany(x => x.Members);
    }
}