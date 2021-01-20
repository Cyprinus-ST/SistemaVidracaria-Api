using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Material;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations.Material
{
    public class MaterialImplementation : BaseRepository<MaterialEntity>,IMaterialRepository
    {
        private DbSet<MaterialEntity> _dataset;

        public MaterialImplementation(MyContext context): base(context)
        {
            _dataset = context.Set<MaterialEntity>();
        }
    }
}
