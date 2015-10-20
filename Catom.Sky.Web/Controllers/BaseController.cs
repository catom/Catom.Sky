using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Catom.Sky.Component.Data;

namespace Catom.Sky.Web.Controllers
{
    public class BaseController : Controller
    {
        // Constructor.
        public BaseController()
        {
        }

        // 初始注入数据层、业务逻辑层
        [Dependency("UnitOfWork")]
        public IUnitOfWork UnitOfWork { set; get; }

        [Dependency("ReadUnitOfWork")]
        public IUnitOfWork ReadUnitOfWork { set; get; }

        [Dependency("WriteUnitOfWork")]
        public IUnitOfWork WriteUnitOfWork { set; get; }



    }
}
