using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();


            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Data Source=DPCCAIODUARTE\\SQLEXPRESS; Initial Catalog = db_vidracaria; Integrated Security = False;User ID = sa; Password = x;")
            );
        }
    }
}
