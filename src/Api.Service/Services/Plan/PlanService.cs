using Api.Domain.DTO.Plan;
using Api.Domain.Entities.Plan;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Plan;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Plan
{
    public class PlanService : IPlanService
    {
        public IPlanRepository _repository;
        public IMapper _mapper;

        public PlanService(IPlanRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<object> AddPlan(AddPlanInput input)
        {
            if (string.IsNullOrEmpty(input.Name) || input.Price < 0)
            {
                throw new Exception("Campos inválidos");
            }

            input.Status = "ACTIVE";

            // var planMapped = _mapper.Map<PlanEntity>(input);
            var entity = new PlanEntity();
            entity.Name = input.Name;
            entity.Description = input.Description;
            entity.Price = input.Price;
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
                var listPlan = _mapper.Map<List<PlanDTO>>(lisResult);
                return listPlan;
            } catch(Exception e){
                throw e;
            }
        }
    }
}
