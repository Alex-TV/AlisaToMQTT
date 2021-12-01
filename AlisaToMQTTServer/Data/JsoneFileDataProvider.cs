
namespace AlisaToMQTTServer.Data
{
    public class JsoneFileDataProvider : IDataProvider
    {

        public JsoneFileDataProvider()
        {
        }

        public void Initialize()
        {
        }

        public List<DataModel> GetData(string name)
        {
            var result = new List<DataModel>();

            var directoryName = JsoneFileDataHelpers.GetDataDirectory(name);

            if (string.IsNullOrEmpty(directoryName))
            {
                return result;
            }

            if (!Directory.Exists(directoryName))
            {
                return result;
            }

            var files = Directory.GetFiles(directoryName, "*.json");

            foreach (var file in files)
            {
                result.Add(ReadFile(file).Result);
            }
            return result;
        }

        private async Task<DataModel> ReadFile(string name)
        {
            using (var reader = File.OpenText(name))
            {
                var data = await reader.ReadToEndAsync();
                return new DataModel(name, data);
            }
        }
    }
}
