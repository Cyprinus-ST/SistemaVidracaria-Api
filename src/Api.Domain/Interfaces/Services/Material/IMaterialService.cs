using Api.Domain.DTO.Material;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Material
{
    public interface IMaterialService
    {
        public Task<object> AddMaterial(AddMaterialInput Material);
    }
}
