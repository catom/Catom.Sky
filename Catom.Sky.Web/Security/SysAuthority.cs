using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Catom.Sky.Web.Security.Model;
using Catom.Sky.Web.App_Start;
using Catom.Sky.Component.Util;


namespace Catom.Sky.Web.Security
{
    public class SysAuthority : FilterAttribute , IAuthorizationFilter
    {
        public SysAuthority()
        {

        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            // TODO auth here.
            var mySession = Bootstrapper.Instance.UnityContainer.Resolve<IMySession>();
            var user = mySession["CurrUser"] as CurrentUser;
            

        }

    }
}