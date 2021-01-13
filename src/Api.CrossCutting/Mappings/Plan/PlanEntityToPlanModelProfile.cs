using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Plan;
using AutoMapper;

namespace Api.CrossCutting.Mappings.Plan
{
    public class PlanEntityToPlanModelProfile : Profile
    {
        public PlanEntityToPlanModelProfile()
        {
            CreateMap<PlanEntity, PlanDTO>()
                .ReverseMap();
        }
    }
}
