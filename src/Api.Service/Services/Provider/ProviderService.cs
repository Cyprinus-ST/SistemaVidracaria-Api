using Api.Domain.DTO.Provider;
using Api.Domain.Entities.Provider;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Provider;
using Api.Domain.Model.Provider;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Service.Services.Provider
{
    public class ProviderService : IProviderService
    {
        public IMapper mapper;
        public IProviderRepository repository;

        public ProviderService(IProviderRepository _repository, IMapper _mapper)
        {
            mapper = _mapper;
            repository = _repository;
        }

        public async Task<object> AddProvider(AddInputProvider input)
        {
            try
            {
                var entity = mapper.Map<ProviderEntity>(input);

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        message = "Fornecedor cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o fornecedor!");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<object> DeleteProvider(Guid Id)
        {
            try
            {
                var result = await repository.DeleteAsync(Id);
                if (result)
                {
                    return new
                    {
                        valid = true,
                        message = "Fornecedor excluído com sucesso!"
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Ocorreu um erro ao excluir o fornecedor, tente novamente mais tarde!"
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetAllProvider(Guid IdUser)
        {
            try
            {
                List<ProviderEntity> listProvider = await repository.FindByIdUser(IdUser);

                if (listProvider.Count() > 0)
                {
                    var result = mapper.Map<List<ProviderModel>>(listProvider);

                    return new
                    {
                        valid = true,
                        listProvider = result

                    };

                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Não encontramos fornecedores cadastrados para esse usuário!"
                    };
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<object> GetByIdProvider(Guid Id)
        {
            try
            {
                var result = await repository.SelectAsync(Id);
                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        result
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Não encontramos nenhum fornecedor com esse registro!"
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> UpdateProvider(UpdateInputProvider input)
        {
            try
            {
                var provider = await repository.SelectAsync(input.Id);

                if (provider == null)
                    throw new Exception("Não foi encontrado esse fornecedor na nossa base de dados!");

                var entity = mapper.Map<ProviderEntity>(input);
                await repository.UpdateAsync(entity);

                return new
                {
                    valid = true,
                    message = "Fornecedor alterado com sucesso!"
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
