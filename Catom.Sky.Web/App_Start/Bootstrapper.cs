using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System.Data;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Util;

namespace Catom.Sky.Web.App_Start
{
    public sealed class Bootstrapper
    {
        #region 1. 载体类，单例模式
        private static Bootstrapper instance = null;
        public static Bootstrapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bootstrapper();
                }
                return instance;
            }
        }
        #endregion

        #region 2. IoC 容器实例对象
        private IUnityContainer unityContainer = null;

        // IoC 容器实例
        public IUnityContainer UnityContainer
        {
            get
            {
                return this.unityContainer;
            }
        }
        #endregion

        #region 3. 初始化 IoC 容器，注入各种类；在 Web 启动时，设置全局 IoC 对象。
        public void Initialise()
        {
            this.unityContainer = new UnityContainer();
            BuildUnityContainer();
            // 将容器设置为全局 IoC 对象。
            DependencyResolver.SetResolver(new UnityDependencyResolver(this.unityContainer));
        }

        /// <summary>
        ///  注入映射关系。
        /// </summary>
        private void BuildUnityContainer()
        {
            #region DAL 映射注入
            string Conn = ConfigurationManager.ConnectionStrings["SkyConn"].ConnectionString;
            string ReadConn = ConfigurationManager.ConnectionStrings["SkyReadConn"].ConnectionString;
            string WriteConn = ConfigurationManager.ConnectionStrings["SkyWriteConn"].ConnectionString;
            unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "UnitOfWork", new InjectionConstructor(Conn));
            unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "ReadUnitOfWork", new InjectionConstructor(ReadConn));
            unityContainer.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork), "WriteUnitOfWork", new InjectionConstructor(WriteConn));
            #endregion

            #region 缓存、session等的注入
            NameValueCollection nvc = ConfigurationManager.AppSettings;
            string serverList = nvc["ServerList"];
            string[] serverIPs = serverList.Split(',');
            string cachedArea = nvc["CachedArea"];
            IMySession mySession = new MySession(serverIPs, int.Parse(nvc["SessionExpireHours"]), nvc["SessionCookieDomain"], nvc["SessionArea"]);
            unityContainer.RegisterInstance(typeof(IMySession), mySession);
            ICache myMemCache = new MemCache(serverIPs, cachedArea);
            //ICache myOcsCache = new OCSCache();
            unityContainer.RegisterInstance(typeof(ICache), myMemCache);
            #endregion

            #region 接口映射注入

            #endregion

        }

        #endregion

    }
}

