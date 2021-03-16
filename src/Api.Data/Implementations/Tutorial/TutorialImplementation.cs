using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Tutorial;
using Api.Domain.Interfaces.Repository.Tutorial;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Tutorial
{
    public class TutorialImplementation : BaseRepository<TutorialEntity>, ITutorialRepository
    {

        private DbSet<TutorialEntity> Tutorial;

        public TutorialImplementation(MyContext context): base(context)
        {
            Tutorial = context.Set<TutorialEntity>();
        }
        public async Task<List<TutorialEntity>> GetAll()
        {

            List<TutorialEntity> tutorials = await Tutorial.ToListAsync();

            return tutorials;
        }
    }
}
