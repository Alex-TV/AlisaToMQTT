using Microsoft.Extensions.DependencyInjection;
using TestHttpLHttpListener.Data.Builder;
using TestHttpLHttpListener.Initializer;
using TestHttpLHttpListener.Server.Initializer.Commands.Bulder;
using TestHttpLHttpListener.SmartThings.Builder;

namespace TestHttpLHttpListener.Server.Initializer
{
    public static class AppBuilder
    {
        private static ServiceCollection _services;
        private static IServiceProvider _serviceProvider;   
        public static void Build()
        {
            _services = new ServiceCollection();
            _services.AddSingleton <IAppInitializer, AppInitializer>(); 
            _services.AddSingleton <IAppDeInitializer, AppDeInitializer>();

            ServerBuilder.Build(_services);
            CommandsBuilder.Build(_services);
            DataProviderBuilder.Build(_services);
            SmartThingsDataRepositoryBuilder.Build(_services);  

            Start();
        }

        private static void Start()
        {
            _serviceProvider = _services.BuildServiceProvider(true);
            var initializer = _serviceProvider.GetService<IAppInitializer>();
            initializer?.Initialize();
        }

        public static void Close()
        {
            var deInitializer = _serviceProvider.GetService<IAppDeInitializer>();
            deInitializer?.DeInitializer();
        }
    }
}
