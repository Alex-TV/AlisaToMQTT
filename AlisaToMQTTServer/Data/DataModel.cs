
namespace AlisaToMQTTServer.Data
{
    public class DataModel
    {
        public string Context { get; }
        public string Data { get; }

        public DataModel(string context, string data)
        {
            Context = context;
            Data = data;
        }
    }
}
