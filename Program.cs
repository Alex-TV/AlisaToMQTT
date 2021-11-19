// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("Hello, World!");


public class Listener
{

private HttpListener listener = new HttpListener();

public async Task Listen()
{
   listener.Prefixes.Add("https://localhost:443/provider/");
   
}

}