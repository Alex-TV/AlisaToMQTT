using Microsoft.Extensions.DependencyInjection;
using TestHttpLHttpListener.Server.Responses;

namespace TestHttpLHttpListener.Server
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
