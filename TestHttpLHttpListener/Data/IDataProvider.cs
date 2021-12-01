
namespace TestHttpLHttpListener.Data
{
    public interface IDataProvider
    {
        void Initialize();

        List<DataModel> GetData(string name);
    }
}
