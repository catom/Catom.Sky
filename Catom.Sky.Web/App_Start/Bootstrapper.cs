using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Data;
using Microsoft.Practices.Unity.Mvc;

namespace Catom.Sky.Web.App_Start
{
    public sealed class Bootstrapper
    {
        private static Bootstrapper strapper = null;

        public static Bootstrapper Instance
        {
            get
            {
                if (strapper == null)
                {
                    strapper = new Bootstrapper();
                }
                return strapper;
            }
        }

        private IUnityContainer container = null;

        public IUnityContainer UnityContainer
        {
            get
            {
                return this.container;
            }
        }

        public void Initialise()
        {
            BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(this.container));
        }

        public void BuildUnityContainer()
        {
            /*
             * 
             * Unity默认情况下会自动帮我们维护好这些对象的生命周
             * 
             * TransientLifetimeManager，瞬态生命周期，默认情况下，在使用RegisterType进行对象关系注册时如果没有指定生命周期管理器则默认使用这个生命周期管理器，这个生命周期管理器就如同其名字一样，当使用这种管理器的时候，每次通过Resolve或ResolveAll调用对象的时候都会重新创建一个新的对象。
             * 
             * ContainerControlledLifetimeManager，容器控制生命周期管理，这个生命周期管理器是RegisterInstance默认使用的生命周期管理器，也就是单件实例，UnityContainer会维护一个对象实例的强引用，每次调用的时候都会返回同一对象
             * 
            */

            container = new UnityContainer();

            //namevaluecollection nvc = configurationmanager.appsettings;
            //string serverlist = nvc["serverlist"];
            //string cachedarea = nvc["cachedarea"];
            //string[] serverip = serverlist.split(',');
            //imysession mysession = new mysession(serverip, int.parse(nvc["sessionexpirehours"]), nvc["sessioncookiedomain"], nvc["sessionarea"]);
            //container.registerinstance(typeof(imysession), mysession);
            //icache mycache = new memcache(serverip, cachedarea);
            //icache mycache = new ocscache();
            //container.registerinstance(typeof(icache), mycache);

            #region 新的数据访问方式
            //string readconn = configurationmanager.connectionstrings["schoolpalread"].connectionstring;
            //string writeconn = configurationmanager.connectionstrings["schoolpalwrite"].connectionstring;
            //container.registertype(typeof(iunitofwork), typeof(defaultunitofwork), "readunitofwork", new injectionconstructor(readconn));
            //container.registertype(typeof(iunitofwork), typeof(defaultunitofwork), "writeunitofwork", new injectionconstructor(writeconn));
            #endregion

            #region 接口映射

            #endregion
        }
    }
}

