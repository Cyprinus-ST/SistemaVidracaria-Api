using Api.Data.Mapping;
using Api.Domain.Entities.Budget;
using Api.Domain.Entities.Colors;
using Api.Domain.Entities.Costumer;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.Project;
using Api.Domain.Entities.ProjectBudgetEntity;
using Api.Domain.Entities.Provider;
using Api.Domain.Entities.Tutorial;
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
            modelBuilder.Entity<ProjectEntity>(new ProjectMap().Configure);
            modelBuilder.Entity<ProjectTypeEntity>(new ProjectTypeMap().Configure);
            modelBuilder.Entity<BudgetEntity>(new BudgetMap().Configure);
            modelBuilder.Entity<TutorialEntity>(new TutorialMap().Configure);
            modelBuilder.Entity<ProjectBudgetEntity>(new ProjectBudgetMap().Configure);
            modelBuilder.Entity<GlassColorEntity>(new GlassColorMap().Configure);
            modelBuilder.Entity<AluminiumColorEntity>(new AluminiumColorMap().Configure);
            modelBuilder.Entity<StructureColorEntity>(new StructureColorMap().Configure);


            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.Parse("BD43824D-95DE-4B40-BE71-F634B75C47BE"),
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
                    Id = Guid.Parse("2216F112-4C4E-4FDC-B300-EDA19D5DE4E4"),
                    Description = "Plano Experimental",
                    Name = "Plano Experimental",
                    Installments = 0.00,
                    Status = "Ativo",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
            );

            #region Add Project Type

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 1,
                Type = "Janela"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 2,
                Type = "Porta"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 3,
                Type = "Fixo"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 4,
                Type = "Box"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 5,
                Type = "Fechamento de Pia"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 6,
                Type = "Espelho"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 7,
                Type = "Bascula/Maxian-ar"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 8,
                Type = "Guarda-Corpo"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 9,
                Type = "Portas Staley"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 10,
                Type = "Janelas Staley"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 11,
                Type = "Reposição"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 12,
                Type = "Versatik kits"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 13,
                Type = "Slide Door"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 14,
                Type = "Projeto Personalizado"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 15,
                Type = "Portas Retráteis"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 16,
                Type = "Ideia Glass"
            }
            );

            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 17,
                Type = "Sacadas"
            }
            );
            modelBuilder.Entity<ProjectTypeEntity>().HasData(
            new ProjectTypeEntity
            {
                Id = 99,
                Type = "Não selecionar"
            }
            );
            #endregion

            #region Add GlassColor

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 1,
                Description = "Azul"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 2,
                Description = "Box Incolor"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 3,
                Description = "Box Antílope"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 4,
                Description = "Box Bronze"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 5,
                Description = "Box Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 6,
                Description = "Box Verde"
            });


            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 7,
                Description = "Box Mini Boreal"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 9,
                Description = "Box Quadrato"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 10,
                Description = "Bronze"
            });


            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 11,
                Description = "Espelho"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 12,
                Description = "Espelho Bisotê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 13,
                Description = "Espelho Bronze"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 14,
                Description = "Espelho Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 15,
                Description = "Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 16,
                Description = "Fumê Padrão"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 17,
                Description = "Incolor"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 18,
                Description = "Jateado Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 19,
                Description = "Jateado Incolor"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 20,
                Description = "Jateador Verde"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 21,
                Description = "Lacobel Branco"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 22,
                Description = "Lacobel Preto"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 23,
                Description = "Lacobel Vermelho"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 24,
                Description = "Laminado Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 25,
                Description = "Laminado Incolor"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 26,
                Description = "Laminado Verde"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 27,
                Description = "Mini Boreal"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 28,
                Description = "Pontilhado"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 29,
                Description = "Refletivo Champagnhe"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 30,
                Description = "Refletivo Cinza"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 31,
                Description = "Refletivo Verde"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 32,
                Description = "Serigrafado"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 33,
                Description = "Serigrafado Extra Clear Branco"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 34,
                Description = "Serigrafado Extra Clear Nevado"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 35,
                Description = "Serigrafado Extra Clear Branco"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 36,
                Description = "Serigrafado Fume Preto"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 37,
                Description = "Serigrafado Incolor Branco"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 38,
                Description = "Serigrafado Incolor Colorido"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 39,
                Description = "Serigrafado Incolor Nevado"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 40,
                Description = "Temperado Laminado Bronze"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 41,
                Description = "Temperado Laminado Fumê"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 42,
                Description = "Temperado Laminado Incolor"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 43,
                Description = "Temperado Laminado Verde"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 44,
                Description = "Temperado Quadrato"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 45,
                Description = "Verde"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 46,
                Description = "Verde Padrão"
            });

            modelBuilder.Entity<GlassColorEntity>().HasData(
            new GlassColorEntity
            {
                Id = 47,
                Description = "Não Selecionar"
            });

            #endregion

            #region Add AluminiumColor

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 1,
                Description = "Branco"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 2,
                Description = "Brilhante"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 3,
                Description = "Bronze"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 4,
                Description = "Bronze 1003"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 5,
                Description = "Champanhe"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 6,
                Description = "Champanhe 1001"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 7,
                Description = "Champanhe 1002"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 8,
                Description = "Cromada"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 9,
                Description = "Natural"
            });

            modelBuilder.Entity<AluminiumColorEntity>().HasData(
            new AluminiumColorEntity
            {
                Id = 10,
                Description = "Não Selecionar"
            });
            #endregion

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 1,
                Description = "Branco"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 2,
                Description = "Cromado"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 3,
                Description = "Fosco"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 4,
                Description = "Marrom"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 5,
                Description = "Outras"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 6,
                Description = "Preto"
            });

            modelBuilder.Entity<StructureColorEntity>().HasData(
            new StructureColorEntity
            {
                Id = 7,
                Description = "Não selecionar"
            });
        }

    }
}
