using YTool.Interface;

namespace YTool.Service
{
    public class ImageService : IImageInterface
    {
        public string Base64ToImage(string text)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public string ImageToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
    }
}