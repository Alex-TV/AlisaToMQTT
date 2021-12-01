using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestHttpLHttpListener.Server
{
    public class ServerTest
    {
        public bool IsStarted { get; private set; }

        public async Task Start()
        {
            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://*:8843/");

            httpListener.Start();
            IsStarted = true;

            while (true)
            {
                Console.WriteLine("Ожидание подключений...");
                var context = await httpListener.GetContextAsync();

                var request = context.Request;
                //context.Response.Close();

                var keys = request.Headers.AllKeys;
                foreach (var key in keys)
                {
                    Console.WriteLine($"key: {key}");
                    var val = request.Headers.GetValues(key)?.ToList() ?? new List<string>(0);
                    val.ForEach(v => Console.WriteLine($"val: {v}"));
                }
                var buffer = new Memory<byte>();

                var count = await new GZipStream(request.InputStream, CompressionMode.Decompress).ReadAsync(buffer);


                var body = Encoding.UTF8.GetString(buffer.ToArray(), 0, count);

                Console.WriteLine($"body: {body}");

                var response = context.Response;

                string responseStr = "<html><head><meta charset='utf8'></head><body>Привет мир!</body></html>";
                byte[] bufferResponse = Encoding.UTF8.GetBytes(responseStr);

                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(bufferResponse, 0, buffer.Length);

                output.Close();


            }
            httpListener.Stop();
            Console.WriteLine("Обработка подключений завершена");

            IsStarted = false;
        }
    }
}
