using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Material;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Material
{
    public class MaterialImplementation : BaseRepository<MaterialEntity>,IMaterialRepository
    {
        private DbSet<MaterialEntity> Material;

        public MaterialImplementation(MyContext context): base(context)
        {
            Material = context.Set<MaterialEntity>();
        }

        public async Task<List<MaterialEntity>> FindByIdUser(Guid IdUser)
        {
            try
            {
                List<MaterialEntity> listMaterial = Material.Where(m => m.IdUser == IdUser)
                    .ToList();

                return listMaterial;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
