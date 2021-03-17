using Api.Domain.Entities.Colors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GlassColorMap : IEntityTypeConfiguration<GlassColorEntity>
    {
        public void Configure(EntityTypeBuilder<GlassColorEntity> builder)
        {
            builder.ToTable("GlassColor");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}

