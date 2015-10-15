using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catom.Sky.Services.Entity;
using Catom.Sky.Services.HrM;


namespace Catom.Sky.Web.Controllers
{
    public class EmployeeController : BaseController
    {
        public ActionResult EmployeeInfo(long id)
        {
            using (UnitOfWork)
            {
                var hrm = new HrManage(UnitOfWork);
                var emp = hrm.GetEmployee(id);
                ViewBag.Emp = emp;
                return Json(emp);
            }
        }


    }
}
