using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Catom.Sky.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // 注册区域
            AreaRegistration.RegisterAllAreas();

            // 注册配置类
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);  // 过滤配置，如异常、鉴权过滤等（FilterAttribute, IAuthorizationFilter）。
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);  // 将css、js文件压缩打包成一个文件，提高请求效率。
            AuthConfig.RegisterAuth();  // 外站点账号鉴权注册。
        }

        protected void Application_Shutdown()
        {

        }

    }
}