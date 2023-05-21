using Church.Contexts.AdmContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.AdmContext.Mapping
{
    public class DirectorshipMap : IEntityTypeConfiguration<Directorship>
    {
        public void Configure(EntityTypeBuilder<Directorship> builder)
        {
            #region Idenifiers

            builder.ToTable(nameof(Directorship));
            builder.HasKey(n => n.Id);

            #endregion

            #region Relationship

            builder.HasOne(d => d.Congregation);
            builder.HasOne(d => d.Member);

            #endregion

            #region Properties

            builder.Property(n => n.BoardRole)
                .IsRequired()
                .HasColumnType("TINYINT");
            builder.Property(n => n.EndDate)
                .IsRequired(false)
                .HasColumnType("SMALLDATETIME");
            builder.Property(n => n.IsDeleted)
                .IsRequired()
                .HasColumnType("BIT");
            builder.Property(n => n.Notes)
                .IsRequired(false)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(180);
            builder.Property(n => n.StartDate)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");
            #endregion
        }
    }
}
