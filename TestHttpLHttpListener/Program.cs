using TestHttpLHttpListener.Server.Initializer;

namespace TestHttpLHttpListener
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Build();

            Console.ReadLine();

            AppBuilder.Close();
        }
    }
}


