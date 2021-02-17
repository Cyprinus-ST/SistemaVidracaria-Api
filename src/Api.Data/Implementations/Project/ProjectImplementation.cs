using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTO.Project;
using Api.Domain.Entities.Project;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Project
{
    public class ProjectImplementation : BaseRepository<ProjectEntity>, IProjectRepository
    {
        private DbSet<ProjectEntity> Project;
        private DbSet<ProjectTypeEntity> ProjectType;

        public ProjectImplementation(MyContext context) : base(context)
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

        public List<ProjectEntity> FindProjectFiltered(FilterProjectDTO filter, out int pages)
        {
            try
            {

                var query = from p in Project
                            select p;

                if (!string.IsNullOrEmpty(filter.Title))
                    query = query.Where(p => p.Title.Contains(filter.Title));

                if (filter.ProjectType != 0)
                    query = query.Where(p => p.ProjectType.Equals(filter.ProjectType));

                if (filter.NumberGlass != 0)
                    query = query.Where(p => p.NumberGlass.Equals(filter.NumberGlass));

                if (filter.Start != 0)
                    query = query.Skip(filter.Start);

                
                if (filter.MaxResults != 0 && filter.Page == 0)
                {
                    pages = query.Count()/ filter.MaxResults;
                    query = query.Take(filter.MaxResults);
                }
                else
                {
                    if (filter.MaxResults == 0)
                        filter.MaxResults = 10;

                    pages = query.Count() / filter.MaxResults;
                    query = query.Skip(filter.MaxResults * filter.Page);
                }

         
                List<ProjectEntity> listProjects = query.ToList();

                return listProjects;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
