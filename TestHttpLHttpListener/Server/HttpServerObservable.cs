using System.Net;
using System.Reactive.Linq;

namespace TestHttpLHttpListener.Server
{
    public class HttpServerObservable : IObservable<RequestContext>, IDisposable
    {
        private readonly HttpListener _listener;
        private readonly IObservable<RequestContext> _stream;

        public HttpServerObservable(string url)
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add(url);
            _listener.Start();
            _stream = ObservableHttpContext();
        }
        
        public void Dispose() => _listener.Stop();
        public IDisposable Subscribe(IObserver<RequestContext> observer) => _stream.Subscribe(observer);

        private IObservable<RequestContext> ObservableHttpContext()
        {
            return Observable.Create<RequestContext>(obs =>
                      Observable.FromAsync(() => _listener.GetContextAsync())
                           .Select(c => new RequestContext(c.Request, c.Response))
                           .Subscribe(obs))
                     .Repeat()
                     .Retry()
                     .Publish()
                     .RefCount();
        }
    }
}
