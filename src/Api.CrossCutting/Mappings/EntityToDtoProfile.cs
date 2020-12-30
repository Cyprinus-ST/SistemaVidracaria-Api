using Api.Domain.DTO.User;
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
        }

    }
}
