using Api.Domain.DTO.Material;
using Api.Domain.Entities.Material;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Material;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Material
{
    public class MaterialService : IMaterialService
    {
        public IMapper mapper;
        public IMaterialRepository repository;

        public MaterialService(IMaterialRepository _repository, IMapper _mapper)
        {
            mapper = _mapper;
            repository = _repository;
        }

        public async Task<object> AddMaterial(AddMaterialInput Material)
        {
            try
            {
                var entity = mapper.Map<MaterialEntity>(Material);

                var result = await repository.InsertAsync(entity);

                if(result != null)
                {
                    return new
                    {
                        valid = "true",
                        message = "Material cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o material!");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<object> DeleteMaterial(Guid id)
        {
            try
            {
                var result = await repository.DeleteAsync(id);
                if (result)
                {
                    return new
                    {
                        valid = true,
                        message = "Material excluído com sucesso!"
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Ocorreu um erro ao excluir o material, tente novamente mais tarde!"
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public async Task<object> GetAllMaterial()
        {
            IEnumerable<MaterialEntity> listResult = await repository.SelectAsync();
            return listResult;

        }

        public async Task<object> GetMaterialById(Guid id)
        {
            return await repository.SelectAsync(id);
        }

        public async Task<object> UpdateMaterial(UpdateMaterialInput Material)
        {
            try
            {
                var material = await repository.SelectAsync(Material.id);

                if (material == null)
                    throw new Exception("Não foi encontrado esse material na nossa base de dados!");

                var entity = mapper.Map<MaterialEntity>(Material);
                await repository.UpdateAsync(entity);

                return new
                {
                    valid = true,
                    message = "Material alterado com sucesso!"
                };
            }
            catch (Exception)
            {

                throw;
            }
 
        }
    }
}
