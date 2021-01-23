using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Plan;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Plan;
using Api.Domain.Interfaces.Services.PlanUser;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Plan
{
    public class PlanService : IPlanService
    {
        public IPlanRepository _repository;
        public IPlanUserService _planUserService; 
        public IMapper _mapper;

        public PlanService(IPlanRepository repository, IPlanUserService planUserService, IMapper mapper)
        {
            _repository = repository;
            _planUserService = planUserService;
            _mapper = mapper;
        }
        public async Task<object> AddPlan(AddPlanInput input)
        {
            if (string.IsNullOrEmpty(input.Name) || input.Installments < 0)
            {
                throw new Exception("Campos inválidos");
            }

            input.Status = "Ativo";

            var entity = new PlanEntity();
            entity.Name = input.Name;
            entity.Description = input.Description;
            entity.Installments = input.Installments;
            entity.Status = input.Status;
            await _repository.InsertAsync(entity);

            return new 
            {
                valid = true,
                message = "Plano cadastrado com sucesso"
            };

        }

        public async Task<IEnumerable<PlanDTO>> ListPlan()
        {
            try
            {
                IEnumerable<PlanEntity> lisResult = await _repository.SelectAsync();
                var listPlan = _mapper.Map<IEnumerable<PlanDTO>>(lisResult);
                return listPlan;
            } catch(Exception e){
                throw e;
            }
        }

        public async Task<object> UpdatePlan(Guid id, UpdatePlanInput input)
        {
            var plan = await _repository.SelectAsync(id);

            if(plan == null)
            {
                throw new Exception("Falha ao atualizar o plano!");
            }

            input.ID = id;

            var mappedPlanEntity = _mapper.Map<PlanEntity>(input);
            await _repository.UpdateAsync(mappedPlanEntity);

            return new {
                valid = true,
                message = "Plano alterado com sucesso!"
            };
        }

        public async Task<object> DeletePlan(DeletePlanInput input)
        {
            var plan = await _repository.SelectAsync(input.ID);

            if (plan == null)
            {
                throw new Exception("Falha ao deletar o plano!");
            }

            if (await _planUserService.ExistUsersinPlan(plan.Id);)
            {
                throw new Exception("Falha a oexcluir o plano da base de dados! Existem usuários vinculados a este plano!");
            }

            await _repository.DeleteAsync(plan.Id);

            return new
            {
                valid = true,
                message = "Plano deletado com sucesso!"
            };
        }

    }
}
