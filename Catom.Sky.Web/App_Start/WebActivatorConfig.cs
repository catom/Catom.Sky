﻿using System;
using Catom.Sky.Web;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebActivatorConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(WebActivatorConfig), "Shutdown")]

namespace Catom.Sky.Web
{
    /// <summary>
    ///  WebActivatorEx 作用等同 Global.asax.cs 启动配置。
    /// </summary>
    public static class WebActivatorConfig
    {

        /// <summary>
        ///  Web 项目启动时。
        /// </summary>
        public static void Start()
        {
            #region 通过 UnityContainer 注册依赖关系

            //var container = UnityConfig.GetConfiguredContainer();
            //FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            //FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));
            //DependencyResolver.SetResolver(container);

            #endregion


        }

        /// <summary>
        ///  Web 项目停止时。
        /// </summary>
        public static void Shutdown()
        {
            // 注销 UnityContainer
            var container = UnityConfig.GetConfiguredContainer();
            container.Dispose();
        }

    }

    #region 需要注册的配置类。
    /// <summary>
    /// IoC 容器注入。等同 Bootstrapper。
    /// </summary>
    public class UnityConfig
    {
        // 延迟实例，构造 Unity 容器。
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        /// <summary>
        ///  在 UnityContainer 中注册 类型映射。
        /// </summary>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            container.LoadConfiguration();

            // TODO: Register your types here
            #region 新的数据访问方式
            // TODO  此处的内容已放在 Bootstrapper 中。

            #endregion

        }
    }

    #endregion

}