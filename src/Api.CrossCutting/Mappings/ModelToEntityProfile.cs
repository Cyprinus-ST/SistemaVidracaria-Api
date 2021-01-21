using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.User;
using Api.Domain.Model.Material;
using Api.Domain.Model.Plan;
using Api.Domain.Model.User;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();
            CreateMap<PlanEntity, UpdatePlanInput>()
                .ReverseMap();
            CreateMap<PlanUserEntity, PlanUserModel>()
                .ReverseMap();
            CreateMap<MaterialEntity, MaterialModel>()
                .ReverseMap();

        }
    }
}
