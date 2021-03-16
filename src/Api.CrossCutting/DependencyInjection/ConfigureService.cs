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
using Api.Domain.Interfaces.Services.Provider;
using Api.Service.Services.Provider;
using Api.Domain.Interfaces.Services.Project;
using Api.Service.Services.Project;
using Api.Domain.Interfaces.Services.Payment;
using Api.Service.Services.Payment;
using Api.Domain.Interfaces.Services.Costumer;
using Api.Service.Services.Costumer;
using Api.Service.Services.Budget;
using Api.Domain.Interfaces.Services.Budget;
using Api.Domain.Interfaces.Services.Tutorial;
using Api.Service.Services.Tutorial;

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
            serviceCollection.AddTransient<IProviderService, ProviderService>();
            serviceCollection.AddTransient<IProjectService, ProjectService>();
            serviceCollection.AddTransient<IPaymentService, PaymentService>();
            serviceCollection.AddTransient<ICostumerService, CostumerService>();
            serviceCollection.AddTransient<IBudgetService, BudgetService>();
            serviceCollection.AddTransient<ITutorialService, TutorialService>();
        }
    }
}
