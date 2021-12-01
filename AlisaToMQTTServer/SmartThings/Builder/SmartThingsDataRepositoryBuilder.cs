using Microsoft.Extensions.DependencyInjection;
using AlisaToMQTTServer.Data;

namespace AlisaToMQTTServer.SmartThings.Builder
{
    public static class SmartThingsDataRepositoryBuilder
    {
        public static void Build(ServiceCollection services)
        {
            services.AddSingleton<ISmartThingsDataRepository, SmartThingsDataRepository>();
        }
    }
}
