using System.Text.Json;
using AlisaToMQTTServer.SmartThings;
using AlisaToMQTTServer.SmartThings.JsonCustomDeserialize;
using AlisaToMQTTServer.SmartThings.Models;

namespace AlisaToMQTTServer.Data
{
    public class SmartThingsDataRepository : ISmartThingsDataRepository
    {
        private readonly IDataProvider _dataProvider;
        private Dictionary<SmartThingsTypes, List<SmartThingsModel>> _repository = new Dictionary<SmartThingsTypes, List<SmartThingsModel>>();

        public SmartThingsDataRepository(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Initialize()
        {
            var dataModels = _dataProvider.GetData(SmartThingsTypes.Light.ToString());
            AddToRepository(SmartThingsTypes.Light, dataModels);
        }

        private void AddToRepository(SmartThingsTypes smartThingsTypes, List<DataModel> dataModels )
        {
            var serializeOptions = new JsonSerializerOptions();
            serializeOptions.Converters.Add(new SmartThingsCapabilitiesConverterWithTypeDiscriminator());
            foreach (var dataModel in dataModels)
            {
                var smartThingsModel = JsonSerializer.Deserialize<SmartThingsModel>(dataModel.Data, serializeOptions);
                if (smartThingsModel == null)
                {
                    continue;
                }
                if (!_repository.ContainsKey(SmartThingsTypes.Light))
                {
                    _repository[SmartThingsTypes.Light] = new List<SmartThingsModel>();
                }
                _repository[SmartThingsTypes.Light].Add(smartThingsModel);
            }
        }

    }
}
