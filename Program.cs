using Microsoft.Extensions.DependencyInjection;
using PluginFramewrok.Abstractions;
using PluginFramewrok.Effects;

namespace PluginFramewrok
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var pluginRegiser = serviceProvider.GetService<IPluginCatalog>();
            pluginRegiser.Register(new ConvertToGrayScaleEffect());
            pluginRegiser.Register(new ResizeEffect());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPluginCatalog, PluginCatalog>();
        }
    }
}
