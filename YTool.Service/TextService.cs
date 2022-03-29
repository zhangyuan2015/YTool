using YTool.Interface;

namespace YTool.Service
{
    public class TextService : ITextInterface
    {
        public string RemoveDuplicate(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return string.Join(Environment.NewLine, GetTextArr(text).Distinct().ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ToUpper(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.ToUpper()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ToLower(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.ToLower()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        public string AddSingleQuotes(string text, bool isReverse)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            if (isReverse)
            {
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.Trim('\'')));
            }
            else
            {
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => "'" + a.Trim('\'') + "'"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        public string AddDoubleQuotes(string text, bool isReverse)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            if (isReverse)
            {
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.Trim('"')));
            }
            else
            {
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => "\"" + a.Trim('"') + "\""));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isReverse"></param>
        /// <returns></returns>
        public string AddComma(string text, bool isReverse)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            if (isReverse)
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.TrimEnd(',')));
            else
            {
                return string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.TrimEnd(',') + ","));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="groupCount"></param>
        /// <returns></returns>
        public string Group(string text, int groupCount)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            var textList = GetTextArr(text);

            List<string> listGroup = new List<string>();
            int index = 1;
            for (int i = 0; i < textList.Count; i += groupCount)
            {
                listGroup.Add("GROUP-" + (index++));
                listGroup.AddRange(textList.Skip(i).Take(groupCount).ToList());
            }
            return string.Join(Environment.NewLine, listGroup);
        }

        private List<string> GetTextArr(string text)
        {
            return text.Replace("\n", "^").Split(new[] { '^' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToList();
        }
    }
}