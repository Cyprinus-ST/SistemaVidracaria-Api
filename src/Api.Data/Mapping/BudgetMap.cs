using Api.Domain.Entities.Budget;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class BudgetMap : IEntityTypeConfiguration<BudgetEntity>
    {
        public void Configure(EntityTypeBuilder<BudgetEntity> builder)
        {
            builder.ToTable("Budget");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.IdCostumer)
                .IsRequired();

            builder.Property(b => b.IdProject)
                .IsRequired();

            builder.Property(b => b.IdUser)
                .IsRequired();

            builder.Property(b => b.Description)
                .HasMaxLength(300);

            builder.Property(b => b.Status)
                .HasMaxLength(15);
        }
    }
}
