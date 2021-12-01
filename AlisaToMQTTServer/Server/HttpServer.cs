using System.Reactive.Linq;
using System.Text;
using AlisaToMQTTServer.Server.Responses;

namespace AlisaToMQTTServer.Server
{
    public class HttpServer : IHttpServer
    {
        private HttpServerObservable? _server;    

        public void Start()
        {
            //var htmlResponseTemplate = "<html><head><meta charset='utf8'></head><body>{0}</body></html>";
            //var jsoneResponseTemplate = @"\{""ansver"":{0}\}";

            _server = new HttpServerObservable("http://*:8843/");
            //var json = JsonConvert.
            //Проверка доступности Endpoint URL провайдера
            _server.Where(ctx => ctx.Request.HttpMethod == "HEAD")
                      .Where(ctx => ctx.Request.RawUrl == "/")
                      .Subscribe(ctx => ctx.Respond(new OkResponseContext()));
            //Информация об устройствах пользователя
            _server.Where(ctx => ctx.Request.HttpMethod == "POST")
                  .Where(ctx => ctx.Request.RawUrl == "/user/unlink")
                  .Subscribe(ctx => ctx.Respond(new StringResponseContext(JsoneResponse("Информация об устройствах пользователя"))));
            //Информация об устройствах пользователя
            _server.Where(ctx => ctx.Request.HttpMethod == "GET")
                  .Where(ctx => ctx.Request.RawUrl == "/user/devices")
                  .Subscribe(ctx => ctx.Respond(new StringResponseContext(JsoneResponse("Информация об устройствах пользователя"))));
            //Информация о состояниях устройств пользователя
            _server.Where(ctx => ctx.Request.HttpMethod == "POST")
                  .Where(ctx => ctx.Request.RawUrl == "/user/devices/query")
                  .Subscribe(ctx => ctx.Respond(new StringResponseContext(JsoneResponse("Информация о состояниях устройств пользователя"))));
            //Изменение состояния у устройств
            _server.Where(ctx => ctx.Request.HttpMethod == "POST")
                  .Where(ctx => ctx.Request.RawUrl == "/user/devices/action")
                  .Subscribe(ctx => ctx.Respond(new StringResponseContext(JsoneResponse("Изменение состояния у устройств"))));
        }

        public void Stop()
        {
            _server?.Dispose(); 
        }

        private string JsoneResponse(string val)
        {
            return new StringBuilder()
                  .Append("{\"ansver\":")
                  .Append("\"")
                  .Append(val)
                  .Append("\"")
                  .Append("}")
                  .ToString();
        }
    }
}
