using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Project;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Project
{
    public class ProjectImplementation : BaseRepository<ProjectEntity>, IProjectRepository
    {
        private DbSet<ProjectEntity> Project;
        private DbSet<ProjectTypeEntity> ProjectType;

        public ProjectImplementation(MyContext context): base(context)
        {
            Project = context.Set<ProjectEntity>(); 
            ProjectType = context.Set<ProjectTypeEntity>(); 
        }

        public async Task<List<ProjectTypeEntity>> ListProjectType()
        {
            return await ProjectType.ToListAsync();
        }

        public async Task<ProjectTypeEntity> FindProjectType(int Id)
        {
          return await ProjectType.FirstOrDefaultAsync(p => p.Id.Equals(Id));
        }
    }
}
