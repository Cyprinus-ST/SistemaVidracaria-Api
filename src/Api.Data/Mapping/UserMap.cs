using Api.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Email)
                .HasMaxLength(100);

            builder.Property(u => u.CPF)
                .HasMaxLength(14);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.PathAvatar)
                .HasMaxLength(450);

            builder.Property(u => u.Type)
                .HasMaxLength(10);

            builder.Property(u => u.Street)
                .HasMaxLength(150);

            builder.Property(u => u.Neighborhood)
                .HasMaxLength(100);

            builder.Property(u => u.City)
                .HasMaxLength(100);

            builder.Property(u => u.State)
                .HasMaxLength(2);

            builder.Property(u => u.Country)
                .HasMaxLength(30);

            builder.Property(u => u.Number)
                .HasMaxLength(15);

            builder.Property(u => u.Complement)
                .HasMaxLength(150);

            builder.Property(u => u.Phone)
                .HasMaxLength(12);

            builder.Property(u => u.TokenPassword)
                .HasMaxLength(100);

        }
    }
}
