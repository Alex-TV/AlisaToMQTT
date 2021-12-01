
using System.Text.Json;
using TestHttpLHttpListener.SmartThings;
using TestHttpLHttpListener.SmartThings.Models;

namespace TestHttpLHttpListener.Data
{
    public class SmartThingsDataRepository : ISmartThingsDataRepository
    {
        private readonly IDataProvider _dataProvider;

        public SmartThingsDataRepository(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Initialize()
        {
            var data = _dataProvider.GetData(SmartThingsTypes.Light.ToString());

            //var test = new SmartThingsModel("d-d", "test", "test d-d", "living", "light");

            //var json = JsonSerializer.Serialize(test);
            // var lightJson = JsonSerializer.Deserialize<SmartThingsModel>(json);
            var doc = JsonDocument.Parse(data[0].Data);
            var capabilities = doc.RootElement.GetProperty("capabilities");

            var lightJson = JsonSerializer.Deserialize<SmartThingsModel>(data[0].Data);  
        }
    }
}
