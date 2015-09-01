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
        public ActionResult SwtchIndex(string section)
        {
            if (string.IsNullOrEmpty(section))
            {
                return Content("<h3>请输入区域名称！</h3>");
            }

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

        // 导航栏
        public ActionResult Navigation()
        {

            return View();
        }

        // 页脚栏
        public ActionResult Footer()
        {

            return View();
        }

        // 错误页面
        public ActionResult Error()
        {

            return View();
        }
    }
}
