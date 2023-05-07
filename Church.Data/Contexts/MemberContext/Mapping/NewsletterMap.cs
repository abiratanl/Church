using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping
{
    public class NewsletterMap : IEntityTypeConfiguration<Newsletter>
    {
        public void Configure(EntityTypeBuilder<Newsletter> builder)
        {
            #region Idenifiers

            builder.ToTable(nameof(Newsletter));
            builder.HasKey(n => n.Id);

            #endregion

            #region Properties

            builder.Property(n => n.EventDescription)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(180);
            builder.Property(n => n.EventTime)
                .IsRequired()
                .HasColumnType("time");
            builder.Property(n => n.IsDeleted)
                .IsRequired()
                .HasColumnType("BIT");
            builder.Property(n => n.StartDate)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");
            builder.Property(n => n.EndDate)
                .IsRequired()
                .HasColumnType("SMALLDATETIME");
            #endregion
        }
    }
}
