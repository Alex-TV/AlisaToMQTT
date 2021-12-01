using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AlisaToMQTTServer.Server.Poviders
{
    internal class PingResponseProvider : IResponseProvider
    {
        private readonly HttpListenerRequest _request;

        public PingResponseProvider(HttpListenerRequest request)
        {
            _request = request;
        }

        public void Build()
        {

        }
    }
}
