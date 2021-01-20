using Api.Domain.Entities.Material;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class MaterialMap : IEntityTypeConfiguration<MaterialEntity>
    {
        public void Configure(EntityTypeBuilder<MaterialEntity> builder)
        {
            builder.ToTable("Material");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(m => m.Amount)
                .IsRequired();

        }
    }
}
