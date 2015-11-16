using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Catom.Sky.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // NDesc：
            //      name 是路由的名称，并无数据意义；
            //      url 是http端口后面的URL格式，如 http://localhost:1234/demo 中的demo，并且{}中的值可作为Request参数；    
            //      default 默认入口action及参数格式。
            //      多组路由映射，按序匹配。


            // 1. 登陆路由（登陆后将Section参数传入SwitchIndex，进行判断并直接跳转）
            routes.MapRoute(
                name: "Login",
                url: "",
                defaults: new { controller = "Catom", action = "Index" }
            );

            // 2. 首页路由（页面框架）
            routes.MapRoute(
                name: "Index",
                url: "{Section}/Catom",
                defaults: new { controller = "Catom", action = "Index", Section = UrlParameter.Optional }
            );

            // 3. 默认路由
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catom", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}