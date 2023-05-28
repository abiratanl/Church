using Church.Contexts.AdmContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping;

public class LeaderMap : IEntityTypeConfiguration<Leader>
{
    public void Configure(EntityTypeBuilder<Leader> builder)
    {
        #region Idendifiers

        builder.ToTable("Leader");
        builder.HasKey(l => l.Id);

        #endregion

        #region Relationship

        builder.HasOne(l => l.Congregation)
            .WithMany()
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(l => l.Member)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        #endregion

        #region Properties

        builder.Property(l => l.EndDate)
            .IsRequired()
            .HasColumnType("Datetime");
        builder.Property(l => l.IsDeleted)
            .IsRequired()
            .HasColumnType("BIT");
        builder.Property(l => l.Notes)
            .IsRequired(false)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(180);
        builder.Property(l => l.StartDate)
            .IsRequired()
            .HasColumnType("Datetime");
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
    }
}