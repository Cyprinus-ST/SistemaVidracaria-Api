using Api.Domain.DTO.Material;
using Api.Domain.Interfaces.Services.Material;
using AutoMapper;
using System.Threading.Tasks;

namespace Api.Service.Services.Material
{
    public class MaterialService : IMaterialService
    {
        public IMapper mapper;

        public MaterialService()
        {

        }

        public Task<object> AddMaterial(AddMaterialInput Material)
        {
            throw new System.NotImplementedException();
        }
    }
}
