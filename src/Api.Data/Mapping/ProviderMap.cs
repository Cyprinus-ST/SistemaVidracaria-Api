using Api.Domain.Entities.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProviderMap : IEntityTypeConfiguration<ProviderEntity>
    {
        public void Configure(EntityTypeBuilder<ProviderEntity> builder)
        {
            builder.ToTable("Provider");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(m => m.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(m => m.Email)
                .HasMaxLength(150);

            builder.Property(m => m.Descripition)
                .HasMaxLength(350);


        }

    }
}
