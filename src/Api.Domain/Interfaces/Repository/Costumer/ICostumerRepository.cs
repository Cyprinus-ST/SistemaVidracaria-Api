using Api.Domain.Entities.Costumer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface ICostumerRepository : IRepository<CostumerEntity>
    {
        Task<List<CostumerEntity>> FindByIdUser(Guid IdUser);
    }
}
