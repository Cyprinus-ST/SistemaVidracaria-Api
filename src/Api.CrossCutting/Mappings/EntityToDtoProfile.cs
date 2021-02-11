using Api.Domain.DTO.Material;
using Api.Domain.DTO.Plan;
using Api.Domain.DTO.User;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.Provider;
using Api.Domain.Entities.User;
using Api.Domain.DTO.Provider;
using AutoMapper;
using Api.Domain.Entities.Project;
using Api.Domain.DTO.Project;

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
        }

    }
}
