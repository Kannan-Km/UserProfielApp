using Microsoft.Extensions.DependencyInjection;
using UserProfileApp.Core.Services.Interfaces;
using UsersProfileApp.Core.Services;
using UsersProfileApp.DataStore.Repository;

namespace UsersProfileApp.Core.DepencyResolver
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IDataStore, FileStore>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
