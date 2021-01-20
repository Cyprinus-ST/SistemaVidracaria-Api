using Api.Domain.Entities.Costumer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class CostumerMap : IEntityTypeConfiguration<CostumerEntity>
    {
        public void Configure(EntityTypeBuilder<CostumerEntity> builder)
        {
            builder.ToTable("Costumer");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(m => m.Phone)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(150);


        }
    }
}
