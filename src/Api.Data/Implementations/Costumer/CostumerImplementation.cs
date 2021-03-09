using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Costumer;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Costumer
{
    public class CostumerImplementation : BaseRepository<CostumerEntity>, ICostumerRepository
    {

        private DbSet<CostumerEntity> Costumer;
        
        public CostumerImplementation(MyContext context): base(context)
        {
            Costumer = context.Set<CostumerEntity>();
        }

        public Task<bool> ExistCostumer(Guid idCostumer)
        {
            bool result = Costumer.Any(c => c.Id.Equals(idCostumer));
            return Task.FromResult(result);
        }

        public async Task<List<CostumerEntity>> FindByIdUser(Guid IdUser)
        {
            try
            {
                List<CostumerEntity> costumers = Costumer.Where(c => c.IdUser.Equals(IdUser))
                    .OrderBy(c => c.Name)
                    .ToList();

                return costumers;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
