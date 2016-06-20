﻿using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Catom.Sky.Web.Security.Model;
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
            var mySession = UnityBootstrapper.Instance.UnityContainer.Resolve<ISession>();
            var user = mySession["CurrUser"] as CurrentUser;
            

        }

    }
}