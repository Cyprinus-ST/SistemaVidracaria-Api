using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interfaces.Services.Login;
using Api.Service.Services.User;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {

        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
