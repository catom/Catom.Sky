using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Catom.Sky.Web.App_Start.UnityConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(Catom.Sky.Web.App_Start.UnityConfig), "Shutdown")]

namespace Catom.Sky.Web.App_Start
{
    /// <summary>
    ///  WebActivatorEx 作用等同 Global.asax.cs 启动配置。
    /// </summary>
    public static class UnityConfig
    {

        /// <summary>
        ///  Web 项目启动时。
        /// </summary>
        public static void Start()
        {

        }

        /// <summary>
        ///  Web 项目停止时。
        /// </summary>
        public static void Shutdown()
        {

        }


    }
}