using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Util;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using Utility.Util;

namespace Catom.Sky.Web
{
    public sealed class UnityBootstrapper
    {
        #region 1. 载体类，单例模式
        private static UnityBootstrapper _instance;
        public static UnityBootstrapper Instance
        {
            get { return _instance ?? (_instance = new UnityBootstrapper()); }
        }
        #endregion

        #region 2. IoC 容器实例对象
        private IUnityContainer _unityContainer;
        public IUnityContainer UnityContainer
        {
            get
            {
                return _unityContainer;
            }
        }
        #endregion

        #region 3. 初始化 IoC 容器，注入各种 DAL 类；在 Web 启动时，设置全局 IoC 对象。
        public void Initialise()
        {
            _unityContainer = new UnityContainer();
            BuildUnityContainer();

            // 将 Unity 的依赖关系容器注入到 Web 应用程序中
            DependencyResolver.SetResolver(new UnityDependencyResolver(_unityContainer));
        }

        /// <summary>
        ///  注入映射关系。
        /// </summary>
        private void BuildUnityContainer()
        {
            #region DAL 映射注入
            // 配置参数
            var conn = ConfigurationManager.ConnectionStrings["SkyConn"].ConnectionString;
            var readConn = ConfigurationManager.ConnectionStrings["SkyReadConn"].ConnectionString;
            var writeConn = ConfigurationManager.ConnectionStrings["SkyWriteConn"].ConnectionString;
            // 注入
            _unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "UnitOfWork", new InjectionConstructor(conn));
            _unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "ReadUnitOfWork", new InjectionConstructor(readConn));
            _unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "WriteUnitOfWork", new InjectionConstructor(writeConn));
            #endregion

            #region 缓存、session等的注入

            _unityContainer.RegisterInstance(typeof(ISession), new MySession());
            _unityContainer.RegisterInstance(typeof(ICache), new MyCache());

            #endregion

            #region 接口映射注入

            #endregion

        }

        #endregion

    }
}

