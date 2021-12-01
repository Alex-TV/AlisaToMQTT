using Microsoft.Extensions.DependencyInjection;
using AlisaToMQTTServer.Server.Responses;

namespace AlisaToMQTTServer.Server
{
    public static class ServerBuilder
    {
        public static void Build(ServiceCollection services)
        {
            services.AddSingleton<IResponseContextFactory, ResponseContextFactory>();
            services.AddSingleton<IHttpServer, HttpServer>();
        }
    }
}
