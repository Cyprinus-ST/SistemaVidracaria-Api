using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Budget;
using AutoMapper;
using System;
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
    }
}
