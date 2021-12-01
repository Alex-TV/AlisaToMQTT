using Microsoft.Extensions.DependencyInjection;

namespace AlisaToMQTTServer.Data.Builder
{
    public static class DataProviderBuilder
    {
        public static void Build(ServiceCollection services)
        {
            services.AddSingleton<IDataProvider, JsoneFileDataProvider>();
        }
    }
}
