namespace YTool.Interface
{
    public interface IImageInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        string ImageToBase64(byte[] bytes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Base64ToImage(string text);
    }
}