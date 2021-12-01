
namespace AlisaToMQTTServer.Server.Responses
{
    public class EmptyResponseContext : BaseResponseContext
    {
        public EmptyResponseContext(int code) : base(code, string.Empty, string.Empty) { }
    }
}


