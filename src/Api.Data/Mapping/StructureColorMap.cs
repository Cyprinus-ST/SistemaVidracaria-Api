using Api.Domain.Entities.Colors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class StructureColorMap : IEntityTypeConfiguration<StructureColorEntity>
    {
        public void Configure(EntityTypeBuilder<StructureColorEntity> builder)
        {
            builder.ToTable("StructureColor");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description)
                .HasMaxLength(100)
                .IsRequired();        
        }
    }
}
