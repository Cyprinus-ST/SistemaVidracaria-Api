using Api.Domain.Entities.Tutorial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class TutorialMap : IEntityTypeConfiguration<TutorialEntity>
    {
        public void Configure(EntityTypeBuilder<TutorialEntity> builder)
        {
            builder.ToTable("Tutorial");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Url)
                .IsRequired();
        }
    }
}
