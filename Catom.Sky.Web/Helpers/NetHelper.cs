using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace Catom.Sky.Web.Helpers
{
    public class NetHelper
    {
        public static string GetImages(string url, string extName, string dertory)
        {
            var imgRequst = WebRequest.Create(url);
            var response = imgRequst.GetResponse();
            var responseStream = response.GetResponseStream();
            var fileName = string.Format("{0}{1}", DateTime.Now.ToString("HHmmssffff"), extName);
            if (responseStream == null)
                return "";

            string path = dertory + Path.DirectorySeparatorChar + fileName;
            using (var downImage = Image.FromStream(responseStream))
            {
                if (!System.IO.Directory.Exists(dertory))
                {
                    System.IO.Directory.CreateDirectory(dertory);
                }
                downImage.Save(path);
            }

            return path;
        }

        public static string GetFile(string url, string extName, string dertory)
        {
            if (!System.IO.Directory.Exists(dertory))
            {
                System.IO.Directory.CreateDirectory(dertory);
            }
            var r = new Random();

            var fileName = string.Format("{0}{1}{2}", DateTime.Now.ToString("HHmmssffff"), r.Next(10000), extName);
            string path = dertory + Path.DirectorySeparatorChar + fileName;

            WebClient client = new WebClient();
            client.DownloadFile(url, path);

            return path;
        }
    }
}
