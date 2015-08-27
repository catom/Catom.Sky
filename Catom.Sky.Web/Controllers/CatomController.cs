using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catom.Sky.Web.Controllers
{
    public class CatomController : BaseController
    {
        // 1. 页面入口
        public ActionResult SwtchIndex()
        {


            return RedirectToAction("Index");
        }

        // 2. 登陆页面
        public ActionResult Login()
        {

            return View();
        }

        // 3. 主页
        public ActionResult Index()
        {


            return View();
        }
        
    }
}
