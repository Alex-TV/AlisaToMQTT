using Microsoft.Extensions.DependencyInjection;
using AlisaToMQTTServer.SmartThings.InfoRepository;

namespace AlisaToMQTTServer.SmartThings.Builder;

public static class SmartThingsDataRepositoryBuilder
{
    public static void Build(ServiceCollection services)
    {
        services.AddSingleton<ISmartThingsDataInfoRepository, SmartThingsDataInfoRepository>();
    }
}
