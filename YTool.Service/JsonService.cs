using Newtonsoft.Json;
using YTool.Interface;

namespace YTool.Service
{
    public class JsonService : IJsonInterface
    {

        public string Format(string text)
        {
            return JsonWriter(text, Formatting.Indented);
        }

        public string Compression(string text)
        {
            return JsonWriter(text, Formatting.None);
        }

        private string JsonWriter(string text, Formatting formatting)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(text);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = formatting,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
                return string.Empty;
        }
    }
}