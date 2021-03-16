using Api.Domain.Entities.ProjectBudgetEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProjectBudgetMap : IEntityTypeConfiguration<ProjectBudgetEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectBudgetEntity> builder)
        {
            builder.ToTable("ProjectBudget");

            builder.HasKey(pb => pb.Id);

            builder.Property(pb => pb.IdProject)
               .IsRequired();

            builder.Property(pb => pb.IdBudget)
                .IsRequired();

            builder.Property(pb => pb.MeterValue)
                .IsRequired();

            builder.Property(pb => pb.HeightValue)
                .IsRequired();

            builder.Property(pb => pb.WidthValue)
                .IsRequired();

        }
    }
}
