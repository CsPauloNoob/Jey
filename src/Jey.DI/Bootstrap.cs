using Jey.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Jey.Infrastructure.Contexts;

namespace Jey.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<UserService>();
            services.AddDbContext<JeyContext>(c => c.UseSqlite($"Data Source={Environment.CurrentDirectory}"));
        }
    }
}