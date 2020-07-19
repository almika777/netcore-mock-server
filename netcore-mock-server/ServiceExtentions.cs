using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using netcore_mock_server.Configuration;

namespace netcore_mock_server
{
    public static class ServiceExtentions
    {
        public static IServiceCollection InitConfig(this IServiceCollection services)
        {
            var appMode = services.BuildServiceProvider().GetService<IConfiguration>().GetValue<ApplicationMode>("ApplicationMode");
            return services.AddSingleton(new ApplicationConfig(appMode));
        }
    }
}
