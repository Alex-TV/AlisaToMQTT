using AlisaToMQTTServer.SmartThings;

namespace AlisaToMQTTServer.Data;

public static class JsoneFileDataHelpers
{
    private static Dictionary<string, string> _dataDirectorys = new Dictionary<string, string>
        {
            {SmartThingsTypes.Light.ToString(), @".\Resources\Lights" }
        };

    public static string GetDataDirectory(string name)
    {
        if (_dataDirectorys.TryGetValue(name, out var directory))
        {
            return directory;
        }
        return string.Empty;
    }
}

