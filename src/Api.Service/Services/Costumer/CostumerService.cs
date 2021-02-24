using Api.Domain.DTO.Costumer;
using Api.Domain.Entities.Costumer;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Costumer;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Costumer
{
    public class CostumerService : ICostumerService
    {
        public IMapper mapper;
        public ICostumerRepository repository;
        public IBudgetRepository budgetRepository;

        public CostumerService(ICostumerRepository _repository, IMapper _mapper, IBudgetRepository _budgetRepository)
        {
            mapper = _mapper;
            repository = _repository;
            budgetRepository = _budgetRepository;
        }
        public async Task<object> AddCostumer(AddCostumerInput Costumer)
        {
            try
            {
                var entity = mapper.Map<CostumerEntity>(Costumer);

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        message = "Cliente cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o cliente!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> DeleteCostumer(Guid id)
        {
            try
            {
                bool budget = await budgetRepository.ExistBudgetWithCostumer(id);

                if (budget)
                {
                    throw new Exception("Não foi possível excluir o cliente porque ele está vinculado a um ou mais orçamentos!");
                }
                
                var result = await repository.DeleteAsync(id);
                if (result)
                {
                    return new
                    {
                        message = "Cliente excluído com sucesso!"
                    };
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao excluir o cliente, tente novamente mais tarde!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetAllCostumer(Guid IdUser)
        {
            try
            {
                List<CostumerEntity> listResult = await repository.FindByIdUser(IdUser);

                if (listResult.Count > 0)
                {
                    return new
                    {
                        valid = true,
                        listCostumers = listResult
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Não encontramos cliente cadastrado para o usuário!"
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<object> GetCostumerById(Guid id)
        {
            try
            {
                var result = await repository.SelectAsync(id);
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
                        message = "Não encontramos nenhum cliente com esse registro!"
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<object> UpdateCostumer(UpdateCostumerInput Costumer)
        {
            try
            {
                var material = await repository.SelectAsync(Costumer.Id);

                if (material == null)
                    throw new Exception("Não foi encontrado esse cliente na nossa base de dados!");

                var entity = mapper.Map<CostumerEntity>(Costumer);
                await repository.UpdateAsync(entity);

                return new
                {
                    valid = true,
                    message = "Cliente alterado com sucesso!"
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
