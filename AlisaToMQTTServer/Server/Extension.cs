using System.Reactive.Linq;

namespace AlisaToMQTTServer.Server
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
