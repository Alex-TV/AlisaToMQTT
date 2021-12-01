using Microsoft.Extensions.DependencyInjection;
using TestHttpLHttpListener.Data;

namespace TestHttpLHttpListener.SmartThings.Builder
{
    public static class SmartThingsDataRepositoryBuilder
    {
        public static void Build(ServiceCollection services)
        {
            services.AddSingleton<ISmartThingsDataRepository, SmartThingsDataRepository>();
        }
    }
}
