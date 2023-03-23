using YTool.Model;

namespace YTool.Interface
{
    public interface IConcurrencyTestInterface
    {
        Task<string> Post(ItemItem item);

        PostmanModel ConvertToModel(string json);
    }
}