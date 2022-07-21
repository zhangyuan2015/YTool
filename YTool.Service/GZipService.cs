﻿using System.IO.Compression;
using YTool.Interface;

namespace YTool.Service
{
    public class GZipService : IGZipInterface
    {
        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Compress(string text)
        {
            return GZipHelper.CompressString(text);
        }

        /// <summary>
        /// 解压缩
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Decompress(string text)
        {
            return GZipHelper.DecompressString(text);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class GZipHelper
    {
        /// <summary>
        /// 将传入字符串以GZip算法压缩后，返回Base64编码字符
        /// </summary>
        /// <param name="rawString">需要压缩的字符串</param>
        /// <returns>压缩后的Base64编码的字符串</returns>
        public static string CompressString(string rawString)
        {
            if (string.IsNullOrEmpty(rawString))
                return "";

            byte[] rawData = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
            byte[] zippedData = Compress(rawData);
            return Convert.ToBase64String(zippedData);
        }

        /// <summary>
        /// GZip压缩
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] rawData)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream compressedzipStream = new GZipStream(ms, CompressionMode.Compress, true);
            compressedzipStream.Write(rawData, 0, rawData.Length);
            compressedzipStream.Close();
            return ms.ToArray();
        }

        /// <summary>
        /// 将传入的二进制字符串资料以GZip算法解压缩
        /// </summary>
        /// <param name="zippedString">经GZip压缩后的二进制字符串</param>
        /// <returns>原始未压缩字符串</returns>
        public static string DecompressString(string zippedString)
        {
            if (string.IsNullOrEmpty(zippedString))
                return "";

            byte[] zippedData = Convert.FromBase64String(zippedString.ToString());
            return System.Text.Encoding.UTF8.GetString(Decompress(zippedData));
        }

        /// <summary>
        /// ZIP解压
        /// </summary>
        /// <param name="zippedData"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] zippedData)
        {
            MemoryStream ms = new MemoryStream(zippedData);
            GZipStream compressedzipStream = new GZipStream(ms, CompressionMode.Decompress);
            MemoryStream outBuffer = new MemoryStream();
            byte[] block = new byte[1024];
            while (true)
            {
                int bytesRead = compressedzipStream.Read(block, 0, block.Length);
                if (bytesRead <= 0)
                    break;
                else
                    outBuffer.Write(block, 0, bytesRead);
            }
            compressedzipStream.Close();
            return outBuffer.ToArray();
        }
    }
}