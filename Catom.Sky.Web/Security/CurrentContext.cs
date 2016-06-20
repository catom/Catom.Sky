using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Catom.Sky.Web.Security.Model;
using Catom.Sky.Component.Util;

namespace Catom.Sky.Web.Security
{
    public class CurrentContext : HttpContextBase
    {
        // 存入当前用户。
        public static void SetCurrentUser(CurrentUser user)
        {
            var mySession = UnityBootstrapper.Instance.UnityContainer.Resolve<ISession>();
            mySession.Set("CurrUser", user);
        }

        // 获取当前用户。
        public static CurrentUser GetCurrentUser()
        {
            var mySession = UnityBootstrapper.Instance.UnityContainer.Resolve<ISession>();
            var user = mySession["CurrUser"] as CurrentUser;
            return user;
        }

        // 清除用户。
        public static void ClearUser()
        {
            var mySession = UnityBootstrapper.Instance.UnityContainer.Resolve<ISession>();
            mySession["CurrUser"] = null;
        }

    }
}