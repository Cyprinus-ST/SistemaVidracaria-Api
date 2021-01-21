using Api.Domain.DTO.Material;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Material
{
    public interface IMaterialService
    {
        public Task<object> AddMaterial(AddMaterialInput Material);
        public Task<object> UpdateMaterial(UpdateMaterialInput Material);
        public Task<object> DeleteMaterial(Guid id);
        public Task<object> GetAllMaterial(Guid IdUser);
        public Task<object> GetMaterialById(Guid id);
    }
}
