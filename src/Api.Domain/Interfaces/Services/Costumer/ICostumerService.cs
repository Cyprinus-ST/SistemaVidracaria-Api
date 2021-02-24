using Api.Domain.DTO.Costumer;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Costumer
{
    public interface ICostumerService
    {
        public Task<object> AddCostumer(AddCostumerInput Costumer);
        public Task<object> UpdateCostumer(UpdateCostumerInput Costumer);
        public Task<object> DeleteCostumer(Guid id);
        public Task<object> GetAllCostumer(Guid IdUser);
        public Task<object> GetCostumerById(Guid id);
    }
}
