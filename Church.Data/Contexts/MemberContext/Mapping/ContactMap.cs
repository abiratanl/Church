using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            #region Identifiers

            builder.ToTable(nameof(Contact));   

            builder.HasKey(x => x.Id);

            #endregion

            #region Relationship

            builder.HasOne(c => c.Member);

            builder.HasOne(c => c.Congregation);

            #endregion

            #region Properties

            builder.Property(c => c.ContactType)
                .IsRequired()
                .HasColumnType("TINYINT");

            builder.Property(c => c.Description)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(180);

            builder.Property(c => c.IsDeleted)
                .IsRequired()
                .HasColumnType("BIT");

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
