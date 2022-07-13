namespace YTool.Interface
{
    public interface IGZipInterface
    {
        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Compress(string text);

        /// <summary>
        /// 解压缩
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Decompress(string text);
    }
}