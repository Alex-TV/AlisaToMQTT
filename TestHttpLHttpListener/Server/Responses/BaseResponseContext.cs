
namespace TestHttpLHttpListener.Server.Responses
{
    public abstract class BaseResponseContext : IResponseContext
    {
        public virtual string Output { get; protected set; }

        public virtual int Code { get; protected set; }

        public virtual string ContentType { get; protected set; }

        protected BaseResponseContext(int code, string contentType, string output)
        {
            Output = output;
            Code = code;
            ContentType = contentType;
        }
    }
}
