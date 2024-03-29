﻿using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Material;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.Project;
using Api.Domain.Entities.Provider;
using Api.Domain.Entities.User;
using Api.Domain.Model;
using Api.Domain.Model.Material;
using Api.Domain.Model.Plan;
using Api.Domain.Model.Provider;
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
            CreateMap<ProviderEntity, ProviderModel>()
                .ReverseMap();
            CreateMap<ProjectEntity, ProjectModel>()
                .ReverseMap();
        }
    }
}
