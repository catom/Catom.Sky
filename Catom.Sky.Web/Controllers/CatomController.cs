using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catom.Sky.Web.Controllers
{
    public class CatomController : BaseController
    {
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        // 主页
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        public ActionResult UserList()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }


        #region 控件页面
        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult ChartShowcase()
        {
            return View();
        }

        public ActionResult CodeEditor()
        {
            return View();
        }

        public ActionResult FormShowcase()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Grids()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult UIElement()
        {
            return View();
        }
        #endregion


        #region 通用部分
        // 错误页面
        public ActionResult Error()
        {

            return View();
        }
        #endregion



    }
}
