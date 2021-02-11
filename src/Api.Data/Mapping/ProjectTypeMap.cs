using Api.Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProjectTypeMap : IEntityTypeConfiguration<ProjectTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectTypeEntity> builder)
        {
            builder.ToTable("ProjectType");

            builder.HasKey(p => p.Id);
        }
    }
}
