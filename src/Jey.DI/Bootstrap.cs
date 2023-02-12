using Jey.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Jey.Infrastructure.Repositories;
using Jey.Domain;
using Jey.Domain.Models;

namespace Jey.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services)
        {
            //services.AddDbContext<JeyContext>(c => c.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), "dbbot.db")}"));

            services.AddScoped<UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<User>), typeof(UserRepository));
        }
    }
}