using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Util;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Catom.Sky.Web
{
    public sealed class IocContainer
    {
        #region 1. 载体类，单例模式
        private static IocContainer _instance;
        public static IocContainer Instance
        {
            get { return _instance ?? (_instance = new IocContainer()); }
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
            // 将容器设置为应用程序的全局 IoC 对象。
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
            var nvc = ConfigurationManager.AppSettings;
            var serverList = nvc["ServerList"];
            var serverIPs = serverList.Split(',');
            var cachedArea = nvc["CachedArea"];
            var mySession = new MySession(serverIPs, int.Parse(nvc["SessionExpireHours"]), nvc["SessionCookieDomain"], nvc["SessionArea"]);
            _unityContainer.RegisterInstance(typeof(IMySession), mySession);
            var myMemCache = new MemCache(serverIPs, cachedArea);
            //ICache myOcsCache = new OCSCache();
            _unityContainer.RegisterInstance(typeof(ICache), myMemCache);
            #endregion

            #region 接口映射注入

            #endregion

        }

        #endregion

    }
}

