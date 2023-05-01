using Church.Contexts.MemberContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.Contexts.MemberContext.Mapping;

public class LeaderMap : IEntityTypeConfiguration<Leader>
{
    public void Configure(EntityTypeBuilder<Leader> builder)
    {
        builder.ToTable("Leader");

        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Congregation);

        builder.HasOne(x => x.MemberId);

        builder.Property(x => x.EndDate)
            .IsRequired()
            .HasColumnType("Datetime");
        builder.Property(x => x.StartDate)
            .IsRequired()
            .HasColumnType("Datetime");
    }
}