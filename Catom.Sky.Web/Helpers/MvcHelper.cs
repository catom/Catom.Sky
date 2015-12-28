using Catom.Sky.Component.Util;
using System.Configuration;
using System.Web;
using Microsoft.Practices.Unity;

namespace Catom.Sky.Web.Helpers
{
    //默认配置项，一般是从config读取
    public class MvcSettings
    {
        public static string ResourceDoMain
        {
            get
            {
                return ConfigHelper.GetConfigString("ResourceDoMain", string.Empty);
            }
        }

        public static string Version
        {
            get
            {       
                ICache DiCache = IocContainer.Instance.UnityContainer.Resolve<ICache>();

                string value = DiCache.Get<string>("Version");
                if (value == null)
                {
                    // TODO

                }

                return value;
            }
        }
    }

    public static class MvcHelpers
    {
        /// <summary>
        /// 页面输出脚本样式语句
        /// </summary>
        /// <param name="html"></param>
        /// <param name="formatStr">字符串format语句</param>
        /// <param name="link">脚本样式连接</param>
        /// <returns></returns>
        private static IHtmlString Render(this System.Web.Mvc.HtmlHelper html, string formatStr, string link)
        {            
            //var ticks = DateTime.Now.ToString("yyyyMMddHH");
            //文件引用后缀改为版本号形式
            var ticks = "version=" + MvcSettings.Version;
            //资源文件站点路径不带"/" 例:http://localhost:9999
            string doMain = MvcSettings.ResourceDoMain;
            return html.Raw(string.Format(formatStr, doMain, link, ticks));
        }

        public static IHtmlString RenderSrc(this System.Web.Mvc.HtmlHelper html, string src)
        {
            string formatStr = "{0}{1}?{2}";
            return Render(html, formatStr, src);
        }

        //输出脚本
        public static IHtmlString RenderScript(this System.Web.Mvc.HtmlHelper html, string link)
        {
            string formatStr = "<script src=\"{0}{1}?{2}\" type=\"text/javascript\"></script>";
            return Render(html, formatStr, link);
        }
        //输入requirejs脚本 附加data-main属性
        //增加requirejs 全局配置
        public static IHtmlString RenderRequireScript(this System.Web.Mvc.HtmlHelper html, string link, string main)
        {
            string formatStr = "<script src=\"{0}{1}?{2}\" type=\"text/javascript\" data-main=\"{3}.js\"></script>";
            //文件引用后缀改为版本号形式
            var ticks = "version=" + MvcSettings.Version;
            //资源文件站点路径不带"/" 例:http://localhost:9999
            string doMain = MvcSettings.ResourceDoMain;
            //requireJs baseURL
            string baseUrl = "/Scripts";
            if (doMain != string.Empty)
            {
                baseUrl = doMain + baseUrl;
            }

            string requireJsGlobalConfig = @"<script>var require = {urlArgs:'" + ticks + @"',baseUrl:'" + baseUrl
                                           + @"'};</script>";
            return html.Raw(requireJsGlobalConfig + string.Format(formatStr, doMain, link, ticks, doMain + main));
        }

        public static IHtmlString RenderRequireScript2(this System.Web.Mvc.HtmlHelper html, string link, string main)
        {
            string formatStr = "<script src=\"{0}{1}?{2}\" type=\"text/javascript\" data-main=\"{3}.js\"></script>";
            //文件引用后缀改为版本号形式
            var ticks = "version=" + MvcSettings.Version;
            //资源文件站点路径不带"/" 例:http://localhost:9999
            string doMain = MvcSettings.ResourceDoMain;
            //requireJs baseURL
            string baseUrl = "/Scripts2/app";
            if (doMain != string.Empty)
            {
                baseUrl = doMain + baseUrl;
            }

            string requireJsGlobalConfig = @"<script>var require = {urlArgs:'" + ticks + @"',baseUrl:'" + baseUrl
                                           + @"'};</script>";
            return html.Raw(requireJsGlobalConfig + string.Format(formatStr, doMain, link, ticks, doMain + main));
        }

        //输出样式表
        public static IHtmlString RenderCss(this System.Web.Mvc.HtmlHelper html, string link)
        {
            string formatStr = "<link href=\"{0}{1}?{2}\" rel=\"stylesheet\" type=\"text/css\" />";
            return Render(html, formatStr, link);
        }

        public static IHtmlString RenderUrl(this System.Web.Mvc.HtmlHelper html, string link)
        {
            string formatStr = "{0}{1}?{2}>";
            return Render(html, formatStr, link);
        }
    }
}
