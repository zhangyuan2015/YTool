using System.Text;
using System.Text.Json;
using YTool.Interface;
using YTool.Model;

namespace YTool.Service
{
    public class ConcurrencyTestService : IConcurrencyTestInterface
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ConcurrencyTestService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public async Task<string> Post(ItemItem item)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var requestContent = new StringContent(item.request.body.raw, Encoding.UTF8);
                /*if (headers != null)
                {
                    foreach (var head in headers)
                    {
                        requestContent.Headers.Add(head.Key, head.Value);
                    }
                }
                if (timeoutSecond != 0)
                    client.Timeout = TimeSpan.FromSeconds(timeoutSecond);*/
                var response = await client.PostAsync(item.request.url.raw, requestContent);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    return $"HttpCode:{response.StatusCode}，Message:{response.ReasonPhrase}";
                }
            }
        }

        public PostmanModel ConvertToModel(string json)
        {
            return JsonSerializer.Deserialize<PostmanModel>(json);
        }
    }
}