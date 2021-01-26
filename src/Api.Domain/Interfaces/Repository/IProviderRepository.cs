using Api.Domain.Entities.Provider;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IProviderRepository : IRepository<ProviderEntity>
    {
        Task<List<ProviderEntity>> FindByIdUser(Guid IdUser);
    }
}
