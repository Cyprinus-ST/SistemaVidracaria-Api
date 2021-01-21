using Api.Data.Mapping;
using Api.Domain.Entities.Costumer;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.Provider;
using Api.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<PlanEntity>(new PlanMap().Configure);
            modelBuilder.Entity<PlanUserEntity>(new PlanUserMap().Configure);
            modelBuilder.Entity<MaterialEntity>(new MaterialMap().Configure);
            modelBuilder.Entity<CostumerEntity>(new CostumerMap().Configure);
            modelBuilder.Entity<ProviderEntity>(new ProviderMap().Configure);


            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrador",
                    Email = "lucas.vilas@email.com",
                    Password = "123456",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
            );

            modelBuilder.Entity<PlanEntity>().HasData(
                new PlanEntity
                {
                    Id = Guid.NewGuid(),
                    Description = "Plano Experimental",
                    Name = "Plano Experimental",
                    Price = 0.00,
                    Status = "Ativo",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
           );
        }

    }
}
