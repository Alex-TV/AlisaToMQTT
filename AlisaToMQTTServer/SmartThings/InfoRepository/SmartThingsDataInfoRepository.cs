using System.Text.Json;
using AlisaToMQTTServer.Data;
using AlisaToMQTTServer.SmartThings.InfoRepository.JsonCustomDeserialize;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models;

namespace AlisaToMQTTServer.SmartThings.InfoRepository;

public sealed class SmartThingsDataInfoRepository : ISmartThingsDataInfoRepository
{
    private readonly IDataProvider _dataProvider;
    private Dictionary<SmartThingsTypes, List<SmartThingsInfoModel>> _repository = new Dictionary<SmartThingsTypes, List<SmartThingsInfoModel>>();

    public SmartThingsDataInfoRepository(IDataProvider dataProvider)
    {
        _dataProvider = dataProvider;
    }

    public void Initialize()
    {
        var dataModels = _dataProvider.GetData(SmartThingsTypes.Light.ToString());
        AddToRepository(SmartThingsTypes.Light, dataModels);
    }

    private void AddToRepository(SmartThingsTypes smartThingsTypes, List<DataModel> dataModels)
    {
        var serializeOptions = new JsonSerializerOptions();
        serializeOptions.Converters.Add(new SmartThingsInfoCapabilitiesConverterWithTypeDiscriminator());
        foreach (var dataModel in dataModels)
        {
            var smartThingsModel = JsonSerializer.Deserialize<SmartThingsInfoModel>(dataModel.Data, serializeOptions);
            if (smartThingsModel == null)
            {
                continue;
            }
            if (!_repository.ContainsKey(SmartThingsTypes.Light))
            {
                _repository[SmartThingsTypes.Light] = new List<SmartThingsInfoModel>();
            }
            _repository[SmartThingsTypes.Light].Add(smartThingsModel);
        }
    }

}

