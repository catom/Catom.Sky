using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper.Contrib.Extensions;
using Catom.Sky.Component.Data;
using Catom.Sky.Services.Entity;
using Catom.Sky.Services.HrM;
using Microsoft.Practices.Unity;
using Catom.Sky.Web.Models;

namespace Catom.Sky.Web.Controllers
{
    public class SalaryController : BaseController
    {
        public JsonResult GetSalary(SalaryRequest req)
        {
            using (UnitOfWork)
            {
                var hrM = new HrManage(UnitOfWork);

                var data = hrM.GetSalary(req.request.Id);
                if (data.Status)
                    return Json((Salary)data.Data, JsonRequestBehavior.AllowGet);
                else
                    return Json(data.Message, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
