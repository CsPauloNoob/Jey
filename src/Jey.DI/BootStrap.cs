using Microsoft.Extensions.DependencyInjection;

namespace Jey.DI
{
    public class BootStrap
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped()
        }
    }
}