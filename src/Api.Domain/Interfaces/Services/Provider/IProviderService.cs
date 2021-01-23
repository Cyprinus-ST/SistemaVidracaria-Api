using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Provider
{
    public interface IProviderService
    {
        public Task<object> AddProvider(AddProviderInput input);
        public Task<object> GetAllProvider(Guid id);

    }
}
