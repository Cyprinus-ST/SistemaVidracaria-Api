using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Implementations.Material;
using Api.Data.Implementations.Plan;
using Api.Data.Implementations.Project;
using Api.Data.Implementations.Provider;
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
            serviceCollection.AddScoped<IPlanRepository, PlanImplementation>();
            serviceCollection.AddScoped<IPlanUserRepository, PlanUserImplementation>();
            serviceCollection.AddScoped<IMaterialRepository, MaterialImplementation>();
            serviceCollection.AddScoped<IProviderRepository, ProviderImplementation>();
            serviceCollection.AddScoped<IProjectRepository, ProjectImplementation>();

            //serviceCollection.AddDbContext<MyContext>(
            //        options => options.UseSqlServer("Password=x;Persist Security Info=True;User ID=sa;Initial Catalog=db_vidracaria;Data Source=DESKTOP-TI83OVD\\SQLEXPRESS")
            //);

            serviceCollection.AddDbContext<MyContext>(
                    options => options.UseSqlServer("server=127.0.0.1;database=db_vidracaria1;user id=sa;password=123456;")
            );
        }
    }
}
