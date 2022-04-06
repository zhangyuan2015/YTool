namespace YTool.Interface
{
    public interface IImageInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string ImageToBase64(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Base64ToImage(string text);
    }
}