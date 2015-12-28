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
            #region 基本配置
            // 注册区域
            AreaRegistration.RegisterAllAreas();

            // 注册配置类
            WebApiConfig.Register(GlobalConfiguration.Configuration);   // 注册 Web.config。
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);  // 过滤配置，如异常、鉴权过滤等（FilterAttribute, IAuthorizationFilter）。
            RouteConfig.RegisterRoutes(RouteTable.Routes);  // 注册Web路由。
            BundleConfig.RegisterBundles(BundleTable.Bundles);  // 将css、js文件压缩打包成一个文件，提高请求效率。
            AuthConfig.RegisterAuth();  // 外站点账号鉴权注册。
            #endregion 

            #region 自定义配置
            // IoC 注册
            IocContainer.Instance.Initialise();
            // 日志配置
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(Server.MapPath("~/log4net.config")));

            #endregion

        }

        protected void Application_Shutdown()
        {

        }

    }
}