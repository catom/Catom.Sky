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

                //var data = hrM.GetSalary(req.request.Id);
                var data = hrM.GetEmployeeAndSalary(req.reqArgs.Month).Data as IEnumerable<EmployeeAndSalary>;
                data = data.Where(e => e.EmployeeId < 10363);

                if (data.Count() > 0)
                    return Json(data, JsonRequestBehavior.AllowGet);
                else
                    return Json("失败", JsonRequestBehavior.AllowGet);
            }
        }

    }
}
