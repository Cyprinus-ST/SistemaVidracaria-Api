using AutoMapper;
using Api.Domain.DTO.User;
using Api.Domain.Model.User;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDTO>()
    .ReverseMap();

            CreateMap<UserModel, UserCreateDTO>()
                .ReverseMap();


        }
    }
}
