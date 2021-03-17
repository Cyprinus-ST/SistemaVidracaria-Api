using Api.Domain.Entities.Colors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AluminiumColorMap : IEntityTypeConfiguration<AluminiumColorEntity>
    {
        public void Configure(EntityTypeBuilder<AluminiumColorEntity> builder)
        {
            builder.ToTable("AluminiumColor");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
