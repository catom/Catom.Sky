using System;
using System.Web.Mvc;
using System.Text;
using Catom.Sky.Component.Util;

namespace Catom.Sky.Web.Filters
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("|Url:");
                sb.Append(filterContext.HttpContext.Request.Url == null ? "" : filterContext.HttpContext.Request.Url.AbsoluteUri);
                sb.Append("\r\n");
                sb.Append(filterContext.Exception.Message.Replace("<", string.Empty).Replace(">", string.Empty));
                sb.Append("\r\n");
                sb.Append(filterContext.Exception.Source);
                sb.Append("\r\n");
                sb.Append(filterContext.Exception.StackTrace);
                sb.Append("\r\n");
                Exception ex = filterContext.Exception.InnerException;
                while (ex != null)
                {
                    sb.Append("\r\n-----------------------");
                    sb.Append(filterContext.Exception.Message.Replace("<", string.Empty).Replace(">", string.Empty));
                    sb.Append("\r\n");
                    sb.Append(filterContext.Exception.Source);
                    sb.Append("\r\n");
                    sb.Append(filterContext.Exception.StackTrace);
                    ex = ex.InnerException;
                }

                StringBuilder sbHeaders = new StringBuilder();
                for (int i = 0; i < filterContext.HttpContext.Request.Headers.Keys.Count; i++)
                {
                    var keyName = filterContext.HttpContext.Request.Headers.AllKeys[i];
                    var strings = filterContext.HttpContext.Request.Headers.GetValues(keyName);
                    if (strings != null)
                        sbHeaders.Append(keyName + ":" + strings[0] + " ");
                }

                // NTODO 写入日志
                LogHelper.WriteLog(sb.ToString());

                filterContext.ExceptionHandled = true;

                //普通请求，返回自定义错误页面
                var urlHelper = new UrlHelper(filterContext.RequestContext);
                var url = urlHelper.Action("Error", "Catom");
                filterContext.Result = new RedirectResult(url);
            }
        }

    }
}