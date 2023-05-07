using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping
{
    public class OccurrenceMap : IEntityTypeConfiguration<Occurrence>
    {
        public void Configure(EntityTypeBuilder<Occurrence> builder)
        {
            #region Identifiers

            builder.ToTable(nameof(Occurrence));
            builder.HasKey(x => x.Id);

            #endregion

            #region Relationship

            builder.HasOne(o => o.Member);

            #endregion

            #region Properties

            builder.Property(o => o.IsDeleted)
                .IsRequired()
                .HasColumnType("BIT");

            builder.Property(o => o.OccurrenceDate)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");

            builder.Property(o => o.OccurrenceType)
                .IsRequired()
                .HasColumnType("TINYINT");

            builder.Property(o => o.Notes)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.OwnsOne(o => o.Tracker)
                .Property(o => o.CreatedAt)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");

            builder.OwnsOne(o => o.Tracker)
                .Property(o => o.UpdatedAt)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");

            builder.OwnsOne(o => o.Tracker)
                .Property(o => o.Notes)
                .HasMaxLength(160)
                .HasColumnType("NVARCHAR");

            #endregion
        }
    }
}
