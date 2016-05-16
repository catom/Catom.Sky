using System;
using System.Linq;
using System.IO;
using System.Net;

namespace CSharpDemo.IOTest
{
    public static class FileHelper
    {
        /// <summary>
        ///  读取网站文件
        /// </summary>
        /// <param name="ossUrl"></param>
        /// <param name="savePath"></param>
        /// <returns></returns>
        public static bool ReadUri(string ossUrl, string savePath)
        {
            try
            {
                // 读取 Oss 文件
                var request = (HttpWebRequest)WebRequest.Create(ossUrl);
                var response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();

                // 写文件
                var fileStream = File.Create(savePath);
                var buffer = new byte[1024];
                var numReadByte = 0;
                while (stream != null && (numReadByte = stream.Read(buffer, 0, 1024)) != 0)
                {
                    fileStream.Write(buffer, 0, numReadByte);
                }
                fileStream.Close();
                if (stream != null) stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        ///  按字节读取文件
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool ReadFileBytes(string url)
        {
            try
            {

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


    }
}
