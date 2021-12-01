namespace TestHttpLHttpListener.Server.Responses
{
    public interface IResponseContext
    {
        string Output { get; }
        int Code { get; }
        string ContentType { get; }
    }
}


