using Microsoft.Extensions.DependencyInjection;
using Store.Repository.Repositories;

namespace Store.Repository
{
    public static class ConfigureRepositories
    {
        public static void AddRepositoriesToCollection(IServiceCollection services)
        {
            services.AddSingleton<UserRepository>();
        }
    }
}