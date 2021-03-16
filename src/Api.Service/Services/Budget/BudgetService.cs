using Api.Data.Constant;
using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Budget;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Budget
{
    public class BudgetService : IBudgetService
    {
        public IMapper mapper;
        public IBudgetRepository repository;
        public ICostumerRepository costumerRepository;
        public IProjectRepository projectRepository;

        public BudgetService(IBudgetRepository _repository, 
            ICostumerRepository _costumerRepository,
            IProjectRepository _projectRepository,
            IMapper _mapper)
        {
            mapper = _mapper;
            repository = _repository;
            costumerRepository = _costumerRepository;
            projectRepository = _projectRepository;
        }
        public async Task<object> AddBudget(AddBudgetInput Budget)
        {
            try
            {
                bool validCostumer = await costumerRepository.ExistCostumer(Budget.IdCostumer);

                if(validCostumer == false)
                {
                    throw new Exception("O id de cliente informado não existe na nossa base de dados!");
                }

                bool validProject = await projectRepository.ExistProject(Budget.IdProject);

                if(validProject == false)
                {
                    throw new Exception("O projeto informado não existe na nossa base de dados!");
                }


                var entity = mapper.Map<BudgetEntity>(Budget);

                entity.Status = BudgetConst.EmAnalise;

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        message = "Orçamento cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o Orçamento!");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<object> DeleteBudget(Guid id)
        {
            try
            {
                var result = await repository.DeleteAsync(id);
                if (result)
                {
                    return new
                    {
                        message = "Orçamento excluído com sucesso!"
                    };
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao excluir o orçamento, tente novamente mais tarde!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetAllBudget(Guid IdUser)
        {
            try
            {
                List<BudgetEntity> listResult = await repository.FindByIdUser(IdUser);

                if (listResult.Count > 0)
                {
                    return new
                    {
                        valid = true,
                        listBudgets = listResult
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Não encontramos orçamentos cadastrados para o usuário!"
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetBudgetById(Guid id)
        {
            try
            {
                var result = await repository.GetBudgetComplete(id);
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
                        message = "Não encontramos nenhum orçamento com esse registro!"
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<object> UpdateBudget(UpdateBudgetInput Budget)
        {
            try
            {
                BudgetEntity entity = mapper.Map<BudgetEntity>(Budget);

                if (entity.Status != BudgetConst.Concluido || entity.Status != BudgetConst.EmAnalise || entity.Status != BudgetConst.EmAndamento)
                {
                    throw new Exception($"Status de orçamento inválido! Status válidos : {BudgetConst.Concluido}, { BudgetConst.EmAnalise } , {BudgetConst.EmAndamento}");
                }

                bool validCostumer = await costumerRepository.ExistCostumer(Budget.IdCostumer);

                if (validCostumer == false)
                {
                    throw new Exception("O id de cliente informado não existe na nossa base de dados!");
                }

                //bool validProject = await projectRepository.ExistProject(entity.IdProject);

                //if (validProject == false)
                //{
                //    throw new Exception("O projeto informado não existe na nossa base de dados!");
                //}

                var budgetExist = await repository.SelectAsync(entity.Id);

                if (budgetExist == null)
                    throw new Exception("Não foi encontrado esse orçamento na nossa base de dados!");

                await repository.UpdateAsync(entity);

                return new
                {
                    valid = true,
                    message = "Orçamento alterado com sucesso!"
                };

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
