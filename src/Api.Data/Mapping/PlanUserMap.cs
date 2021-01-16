using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities.Plan;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PlanUserMap: IEntityTypeConfiguration<PlanUserEntity>
    {
        public void Configure(EntityTypeBuilder<PlanUserEntity> builder)
        {
            builder.ToTable("PlanUser");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.idPlan)
                .IsRequired();

            builder.Property(p => p.idUser)
                .IsRequired();

            builder.Property(p => p.statusPlan)
                .IsRequired();

            builder.Property(p => p.dateAcquisition)
                .IsRequired();

            builder.Property(p => p.dateExpired)
                .IsRequired();
        }
    }
}
