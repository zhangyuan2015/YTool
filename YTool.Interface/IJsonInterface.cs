﻿namespace YTool.Interface
{
    public interface IJsonInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Format(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Compression(string text);
    }
}