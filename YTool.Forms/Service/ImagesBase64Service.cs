using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace YTool.Forms.Service
{
    public static class ImagesBase64Service
    {
        /// <summary>
        /// Image 转成 base64
        /// </summary>
        /// <param name="fileFullName"></param>
        public static string ImageToBase64(string fileFullName)
        {
            try
            {
                Bitmap bmp = new Bitmap(fileFullName);
                MemoryStream ms = new MemoryStream();
                var suffix = fileFullName.Substring(fileFullName.LastIndexOf('.') + 1,
                    fileFullName.Length - fileFullName.LastIndexOf('.') - 1).ToLower();
                var suffixName = suffix == "png" ? ImageFormat.Png : suffix == "jpg" || suffix == "jpeg" ? ImageFormat.Jpeg : suffix == "bmp" ? ImageFormat.Bmp : suffix == "gif" ? ImageFormat.Gif : ImageFormat.Jpeg;

                bmp.Save(ms, suffixName);
                byte[] arr = new byte[ms.Length]; ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length); ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}