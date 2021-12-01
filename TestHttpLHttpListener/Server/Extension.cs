using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace TestHttpLHttpListener.Server
{
    public static class Extension
    {
        public static IObservable<byte[]> ReadBytes(this Stream source)
        {
            return Observable.FromAsync(cancellationToken => 
             {
                 var result = new Memory<byte>();
                 source.ReadAsync(result, cancellationToken);
                 return Task.FromResult(result.ToArray());
             });
        }
    }
}
