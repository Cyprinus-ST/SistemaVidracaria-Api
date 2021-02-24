using Api.Domain.Entities.Material;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IMaterialRepository : IRepository<MaterialEntity>
    {
        Task<List<MaterialEntity>> FindByIdUser(Guid IdUser);
    }
}
