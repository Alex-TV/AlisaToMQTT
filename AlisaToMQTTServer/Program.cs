using AlisaToMQTTServer.Server.Initializer;

namespace AlisaToMQTTServer
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


