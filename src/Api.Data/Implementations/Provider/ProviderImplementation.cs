using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Provider;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Provider
{
    public class ProviderImplementation : BaseRepository<ProviderEntity>, IProviderRepository
    {
        private DbSet<ProviderEntity> Provider;

        public ProviderImplementation(MyContext context): base(context)
        {
            Provider = context.Set<ProviderEntity>();
        }

        public async Task<List<ProviderEntity>> FindByIdUser(Guid IdUser)
        {
            try
            {
                List<ProviderEntity> listProvider = Provider.Where(m => m.IdUser == IdUser)
                    .ToList();

                return listProvider;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
