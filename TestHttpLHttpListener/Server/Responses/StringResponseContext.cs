
namespace TestHttpLHttpListener.Server.Responses
{
    public class StringResponseContext : BaseResponseContext
    {
        public StringResponseContext(string message) : base(200, "application/json", message) { }
    }
}


