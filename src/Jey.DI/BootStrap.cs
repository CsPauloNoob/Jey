using Microsoft.Extensions.DependencyInjection;
using Jey.Domain.Services;
using Jey.Infrastructure.Contexts;
using Jey.Infrastructure.Repositories;
using Jey.Domain.Models;
using Jey.Domain.Interfaces;

namespace Jey.DI
{
    public class BootStrap
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(UserService));
            services.AddScoped(typeof(JeyContext));
            services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));
        }
    }
}