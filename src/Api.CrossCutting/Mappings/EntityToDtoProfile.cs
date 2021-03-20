using Api.Domain.DTO.Budget;
using Api.Domain.DTO.Costumer;
using Api.Domain.DTO.Material;
using Api.Domain.DTO.Plan;
using Api.Domain.DTO.Project;
using Api.Domain.DTO.Provider;
using Api.Domain.DTO.Tutorial;
using Api.Domain.DTO.User;
using Api.Domain.Entities.Budget;
using Api.Domain.Entities.Costumer;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.Project;
using Api.Domain.Entities.ProjectBudgetEntity;
using Api.Domain.Entities.Provider;
using Api.Domain.Entities.Tutorial;
using Api.Domain.Entities.User;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDTO, UserEntity>()
                .ReverseMap();
            CreateMap<PlanEntity, PlanDTO>()
                .ReverseMap();

            CreateMap<MaterialEntity, AddMaterialInput>()
                .ReverseMap();
            CreateMap<MaterialEntity, UpdateMaterialInput>()
                .ReverseMap();

            CreateMap<ProviderEntity, AddInputProvider>()
                .ReverseMap();

            CreateMap<ProviderEntity, UpdateInputProvider>()
                .ReverseMap();

            CreateMap<ProjectEntity, AddProjectInput>()
                .ReverseMap();

            CreateMap<ProjectEntity, UpdateProjectInput>()
                .ReverseMap();

            CreateMap<CostumerEntity, AddCostumerInput>()
                .ReverseMap();

            CreateMap<CostumerEntity, UpdateCostumerInput>()
                .ReverseMap();

            CreateMap<BudgetEntity, AddBudgetInput>()
                .ReverseMap();

            CreateMap<BudgetEntity, UpdateBudgetInput>()
                .ReverseMap();

            CreateMap<TutorialEntity, AddTutorialInput>()
                .ReverseMap();

            CreateMap<TutorialEntity, UpdateTutorialInput>()
                .ReverseMap();

            CreateMap<ProjectBudgetEntity, ProjectBudgetDTO>()
                .ReverseMap();
        }

    }
}
