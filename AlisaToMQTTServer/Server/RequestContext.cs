﻿using System.Net;
using System.Text;
using AlisaToMQTTServer.Server.Responses;

namespace AlisaToMQTTServer.Server;

public sealed class RequestContext
{
    public HttpListenerRequest Request { get; }
    public HttpListenerResponse Response { get; }

    private string _requestId = string.Empty;
    private const string _requestIdKey = "x-request-id";
    public RequestContext(HttpListenerRequest request, HttpListenerResponse response)
    {
        Request = request;
        Response = response;
        if (request.Headers.AllKeys.Contains(_requestIdKey))
        {
            _requestId = request.Headers.Get(_requestIdKey) ?? string.Empty;
        }
    }

    internal void Respond(IResponseContext response)
    {
        Response.ContentType = response.ContentType;
        Response.Headers.Add(_requestIdKey, _requestId);
        Response.ContentEncoding = Encoding.UTF8;
        Response.StatusCode = response.Code;
        Response.OutputStream.Write(Encoding.UTF8.GetBytes(response.Output));
        Response.Close();
    }
}

