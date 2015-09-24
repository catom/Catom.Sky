using System.Web;
using System.Web.Mvc;
using Catom.Sky.Web.Filters;

namespace Catom.Sky.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // DESC 此处添加过滤器
            filters.Add(new MyExceptionFilter());
        }
    }
}