using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interfaces.Services.Login;
using Api.Service.Services.User;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services.Plan;
using Api.Domain.Interfaces.Services.Plan;
using Api.Domain.Interfaces.Services.Material;
using Api.Service.Services.Material;
using Api.Domain.Interfaces.Services.PlanUser;
using Api.Service.Services.PlanUser;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {

        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IPlanService, PlanService>();
            serviceCollection.AddTransient<IMaterialService, MaterialService>();
            serviceCollection.AddTransient<IPlanUserService, PlanUserService>();
        }
    }
}
