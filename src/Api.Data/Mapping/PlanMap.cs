using Api.Domain.Entities.Plan;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PlanMap : IEntityTypeConfiguration<PlanEntity>
    {
        public void Configure(EntityTypeBuilder<PlanEntity> builder)
        {
            builder.ToTable("Plan");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Description)
                .HasMaxLength(500);

            builder.Property(u => u.Installments)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Status)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
