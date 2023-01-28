using Microsoft.Extensions.DependencyInjection;
using Store.Application.Services;
using Store.Repository;

namespace Store.Application
{
    public class Setup
    {
        public static void SetRepositories(IServiceCollection collection)
        {
            ConfigureRepositories.AddRepositoriesToCollection(collection);
        }

        public static void SetServices(IServiceCollection collection)
        {
            collection.AddSingleton<RegisterService>();
            collection.AddSingleton<LoginService>();
            collection.AddSingleton<ProductService>();
        }
    }
}