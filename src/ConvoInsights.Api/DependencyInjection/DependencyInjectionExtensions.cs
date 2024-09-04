using ConvoInsights.Application;
using ConvoInsights.Infrastructure;

namespace ConvoInsights.Api.DependencyInjection;

public static class DependencyInjectionExtensions
{
    public static void AddConvoInsightsServices(this IServiceCollection services, IConfiguration configuration)
    {
       services.AddApplicationServices(configuration);
       services.AddInfrastructureServices(configuration);
    }
}