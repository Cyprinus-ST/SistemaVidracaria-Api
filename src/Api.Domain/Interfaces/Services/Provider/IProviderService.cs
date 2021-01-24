using Api.Domain.DTO.Provider;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Provider
{
    public interface IProviderService
    {
        public Task<object> AddProvider(AddInputProvider input);
        public Task<object> GetAllProvider(Guid IdUser);
        public Task<object> GetByIdProvider(Guid Id);
        public Task<object> UpdateProvider(UpdateInputProvider input);
        public Task<object> DeleteProvider(Guid Id);
    }
}
