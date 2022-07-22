namespace YTool.Interface
{
    public interface ITextInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        string RemoveDuplicate(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string ToUpper(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string ToLower(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        string AddSingleQuotes(string text, bool isReverse);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        string AddDoubleQuotes(string text, bool isReverse);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        string AddComma(string text, bool isReverse);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="groupCount"></param>
        /// <returns></returns>
        string Group(string text, int groupCount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="lineFeedSymbol"></param>
        /// <returns></returns>
        string LineFeed(string text, char? lineFeedSymbol);
    }
}