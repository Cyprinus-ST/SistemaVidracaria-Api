using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.User;
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
        }
    }
}
