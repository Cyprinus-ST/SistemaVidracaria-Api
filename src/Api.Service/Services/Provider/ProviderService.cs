using Api.Domain.Interfaces.Services.Provider;
using System;
using System.Threading.Tasks;

namespace Api.Service.Services.Provider
{
    public class ProviderService : IProviderService
    {
        public Task<object> AddProvider(AddProviderInput input)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetAllProvider(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
