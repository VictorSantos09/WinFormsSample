using Microsoft.Extensions.DependencyInjection;
using Store.Application;

namespace StoreUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new ServiceCollection();

            Setup.SetServices(builder);
            Setup.SetRepositories(builder);

            (new Form1()).Show();
            Application.Run();
        }
    }
}